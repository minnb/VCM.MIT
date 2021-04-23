using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace VCM.MIT.Controllers
{
    public abstract class MITControllerBase: AbpController
    {
        protected MITControllerBase()
        {
            LocalizationSourceName = MITConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }

    }
}
