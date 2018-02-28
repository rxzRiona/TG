using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace TG.Web.Views
{
    public abstract class TGRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected TGRazorPage()
        {
            LocalizationSourceName = TGConsts.LocalizationSourceName;
        }
    }
}
