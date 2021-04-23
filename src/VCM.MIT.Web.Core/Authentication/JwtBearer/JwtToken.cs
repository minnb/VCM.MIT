using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using VCM.MIT.Models.User;

namespace VCM.MIT.Authentication.JwtBearer
{
    public static class JwtToken
    {
        public static string GetUserFromToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(token);
            var tokenS = handler.ReadToken(token) as JwtSecurityToken;
            return tokenS.Claims.Where(c => c.Type == ClaimTypes.Name).FirstOrDefault().Value;
        }
        public static long GetUserIdFromToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(token);
            var tokenS = handler.ReadToken(token) as JwtSecurityToken;
            return long.Parse(tokenS.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).FirstOrDefault().Value);
        }
        public static UserInToken GetUserInfoInToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(token);
            var tokenS = handler.ReadToken(token) as JwtSecurityToken;

            var result = new UserInToken()
            {
                UserId = long.Parse(tokenS.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).FirstOrDefault().Value),
                UserName = tokenS.Claims.Where(c => c.Type == ClaimTypes.Name).FirstOrDefault().Value
            };
            return result;
        }
    }
}
