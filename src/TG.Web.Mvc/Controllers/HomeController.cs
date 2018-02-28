using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using TG.Controllers;

namespace TG.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TGControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
