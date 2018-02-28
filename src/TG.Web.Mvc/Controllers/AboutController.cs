using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using TG.Controllers;

namespace TG.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : TGControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
