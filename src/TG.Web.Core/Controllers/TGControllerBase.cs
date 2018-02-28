using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TG.Controllers
{
    public abstract class TGControllerBase: AbpController
    {
        protected TGControllerBase()
        {
            LocalizationSourceName = TGConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
