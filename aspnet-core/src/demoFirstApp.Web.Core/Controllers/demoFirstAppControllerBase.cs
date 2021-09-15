using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace demoFirstApp.Controllers
{
    public abstract class demoFirstAppControllerBase: AbpController
    {
        protected demoFirstAppControllerBase()
        {
            LocalizationSourceName = demoFirstAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
