using Microsoft.AspNetCore.Antiforgery;
using TG.Controllers;

namespace TG.Web.Host.Controllers
{
    public class AntiForgeryController : TGControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
