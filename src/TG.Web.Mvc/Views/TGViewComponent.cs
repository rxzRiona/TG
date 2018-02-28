using Abp.AspNetCore.Mvc.ViewComponents;

namespace TG.Web.Views
{
    public abstract class TGViewComponent : AbpViewComponent
    {
        protected TGViewComponent()
        {
            LocalizationSourceName = TGConsts.LocalizationSourceName;
        }
    }
}
