using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.MultiTenancy;
using Abp.Runtime.Security;
using Abp.UI;
using Castle.Core.Logging;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using VCM.MIT.Authentication.JwtBearer;
using VCM.MIT.Authorization;
using VCM.MIT.Authorization.Roles;
using VCM.MIT.Authorization.Users;
using VCM.MIT.Controllers;
using VCM.MIT.Identity;
using VCM.MIT.Models.TokenAuth;
using VCM.MIT.Web.Host.ViewModels;

namespace VCM.MIT.Web.Host.Controllers
{
    public class AccountController : MITControllerBase
    {
        private readonly ITenantCache _tenantCache;
        private readonly TokenAuthConfiguration _configuration;
        private readonly IOptions<JwtBearerOptions> _jwtOptions;
        private readonly IRepository<User, long> _repositoryUser;
        private readonly AbpLoginResultTypeHelper _abpLoginResultTypeHelper;
        private readonly LogInManager _logInManager;
        private readonly AbpUserClaimsPrincipalFactory<User, Role> _claimsPrincipalFactory;
        private readonly ILogger _logger;

        public AccountController(
            ITenantCache tenantCache,
            TokenAuthConfiguration configuration,
            IRepository<User, long> userRepository,
            AbpLoginResultTypeHelper abpLoginResultTypeHelper,
            LogInManager logInManager,
            AbpUserClaimsPrincipalFactory<User, Role> claimsPrincipalFactory,
            ILogger logger,
            IOptions<JwtBearerOptions> jwtOptions
            )
        {
            _tenantCache = tenantCache;
            _configuration = configuration;
            _repositoryUser = userRepository;
            _logInManager = logInManager;
            _jwtOptions = jwtOptions;
            _abpLoginResultTypeHelper = abpLoginResultTypeHelper;
            _claimsPrincipalFactory = claimsPrincipalFactory;
            _logger = logger;
        }

        [HttpPost]
        [Route("api/account/login")]
        public async Task<AuthenticateResultModel> LoginAsync([FromBody] LoginViewModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var loginResult = await _logInManager.LoginAsync(loginModel.UserName, loginModel.Password, GetTenancyNameOrNull());
                    switch (loginResult.Result)
                    {
                        case AbpLoginResultType.Success:
                            var accessToken = CreateAccessToken(CreateJwtClaims(loginResult.Identity));
                            var refreshToken = CreateRefreshToken(CreateJwtClaims(loginResult.Identity, tokenType: TokenTypeEnum.RefreshToken));

                            return new AuthenticateResultModel
                            {
                                AccessToken = accessToken,
                                EncryptedAccessToken = GetEncryptedAccessToken(accessToken),
                                ExpireInSeconds = (int)_configuration.AccessTokenExpiration.TotalSeconds,
                                UserId = loginResult.User.Id,
                                IsChangePassword = loginResult.User.IsEmailConfirmed,
                                RefreshToken = refreshToken,
                                RefreshTokenExpireInSeconds = (int)_configuration.RefreshTokenExpiration.TotalSeconds
                            };
                        default:
                            throw _abpLoginResultTypeHelper.CreateExceptionForFailedLoginAttempt(loginResult.Result, loginModel.Password, GetTenancyNameOrNull());
                    }
                }
                else
                {
                    throw new UserFriendlyException(ModelState.Values.First().Errors[0].ErrorMessage.ToString());
                }
            }
            catch (UserFriendlyException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new ValidationException("Exception ", e);
            }
        }

        [HttpPost]
        [Route("api/account/refresh-token")]
        public async Task<RefreshTokenResult> RefreshToken([FromBody] RefreshTokenViewModel payload)
        {
            if (string.IsNullOrWhiteSpace(payload.RefreshToken))
            {
                throw new ArgumentNullException(nameof(payload.RefreshToken));
            }

            if (!IsRefreshTokenValid(payload.RefreshToken, out var principal))
            {
                throw new ValidationException("Refresh token is not valid!");
            }

            try
            {
                var userName = JwtToken.GetUserFromToken(payload.RefreshToken.Trim());
                //var user = _userManager.GetUser(UserIdentifier.Parse(principal.Claims.First(x => x.Type == AppConsts.UserIdentifier).Value));
                var user = _repositoryUser.GetAll().Where(x => x.UserName == userName).SingleOrDefault();
                if (user == null)
                {
                    throw new UserFriendlyException("Unknown user or user identifier");
                }

                principal = await _claimsPrincipalFactory.CreateAsync(user);
               
                var accessToken = CreateAccessToken(CreateJwtClaims(principal.Identity as ClaimsIdentity));

                return await Task.FromResult(new RefreshTokenResult(accessToken, GetEncryptedAccessToken(accessToken), (int)_configuration.AccessTokenExpiration.TotalSeconds));
            }
            catch (UserFriendlyException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new ValidationException("Refresh token is not valid!", e);
            }
        }

        //+++++++++++++++++++++++++++++++++++++++++++ Private 
        private string GetEncryptedAccessToken(string accessToken)
        {
            return SimpleStringCipher.Instance.Encrypt(accessToken, AppConsts.DefaultPassPhrase);
        }
        private string CreateAccessToken(IEnumerable<Claim> claims, TimeSpan? expiration = null)
        {
            var now = DateTime.UtcNow;

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _configuration.Issuer,
                audience: _configuration.Audience,
                claims: claims,
                notBefore: now,
                expires: now.Add(expiration ?? _configuration.AccessTokenExpiration),
                signingCredentials: _configuration.SigningCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        }
        private string CreateRefreshToken(IEnumerable<Claim> claims)
        {
            return CreateAccessToken(claims, AppConsts.RefreshTokenExpiration);
        }
        private static List<Claim> CreateJwtClaims(ClaimsIdentity identity, TimeSpan? expiration = null, TokenTypeEnum tokenType = TokenTypeEnum.AccessToken)
        {
            var tokenValidityKey = Guid.NewGuid().ToString();
            var claims = identity.Claims.ToList();
            var nameIdClaim = claims.First(c => c.Type == ClaimTypes.NameIdentifier);

            // Specifically add the jti (random nonce), iat (issued timestamp), and sub (subject/user) claims.
            claims.AddRange(new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, nameIdClaim.Value),
                new Claim(JwtRegisteredClaimNames.Jti, tokenValidityKey),
                new Claim(JwtRegisteredClaimNames.Iat, DateTimeOffset.Now.ToUnixTimeSeconds().ToString(), ClaimValueTypes.Integer64),
                new Claim(AppConsts.TokenType, tokenType.To<int>().ToString())
            });

            return claims;
        }
        private bool IsRefreshTokenValid(string refreshToken, out ClaimsPrincipal principal)
        {
            principal = null;
            try
            {
                var validationParameters = new TokenValidationParameters
                {
                    ValidAudience = _configuration.Audience,
                    ValidIssuer = _configuration.Issuer,
                    IssuerSigningKey = _configuration.SecurityKey
                };

                foreach (var validator in _jwtOptions.Value.SecurityTokenValidators)
                {
                    if (!validator.CanReadToken(refreshToken))
                    {
                        continue;
                    }

                    try
                    {
                        principal = validator.ValidateToken(refreshToken, validationParameters, out _);

                        if (principal.Claims.FirstOrDefault(x => x.Type == AppConsts.TokenType)?.Value == TokenTypeEnum.RefreshToken.To<int>().ToString())
                        {
                            return true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Debug(ex.ToString(), ex);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Debug(ex.ToString(), ex);
            }
            return false;
        }
        private string GetTenancyNameOrNull()
        {
            if (!AbpSession.TenantId.HasValue)
            {
                return null;
            }

            return _tenantCache.GetOrNull(AbpSession.TenantId.Value)?.TenancyName;
        }
    }
}
