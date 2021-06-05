using Abp.Authorization;
using Abp.UI;
using Castle.Core.Logging;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VCM.MIT.AppService.Trans;
using VCM.MIT.Authentication.JwtBearer;
using VCM.MIT.Controllers;
using VCM.MIT.Models.Trans;
using VCM.MIT.Models.User;
using VCM.MIT.Web.Host.ViewModels;

namespace VCM.MIT.Web.Host.Controllers
{
    [AbpAuthorize]
    public class TransactionsController : MITControllerBase
    {
        private readonly ILogger _logger;
        private readonly ITransService _transRawService;
        public TransactionsController(
            ILogger logger,
            ITransService transRawService
            )
        {
            _logger = logger;
            _transRawService = transRawService;
        }

        [HttpPost]
        [Route("v1/api/transaction/create")]
        public async Task<ResponseModel> CreateOrderAsync([FromBody] TransHeaderModel payload)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var userInfo = JwtToken.GetUserInfoInToken((Request.Headers["Authorization"]).ToString().Substring("Bearer ".Length).Trim());
                    await _transRawService.CreateTransRawAsync(userInfo, payload);

                    return new ResponseModel
                    {
                        Message = "Successfuly"
                    };
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
        [Route("v1/api/transaction/master")]
        public async Task<Object> MasterDataAsync([FromBody] TransRawModel payload)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var userProfile = JwtToken.GetUserInfoInToken((Request.Headers["Authorization"]).ToString().Substring("Bearer ".Length).Trim());

                    return new RspSuccessfully() { RequestId = await _transRawService.CreateTransRawMasterAsync(userProfile, payload) };
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
    }
}
