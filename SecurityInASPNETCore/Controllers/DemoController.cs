using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecurityInASPNETCore.Security;

namespace SecurityInASPNETCore.Controllers
{
    public class DemoController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View("Index");
        }

        [MyAuthorizeAttribute(Roles = "superadmin")]
        public IActionResult Work1()
        {
            return View("Work1");
        }
        [MyAuthorizeAttribute(Roles = "superadmin,admin")]
        public IActionResult Work2()
        {
            return View("Work2");
        }
        [MyAuthorizeAttribute(Roles = "superadmin,admin,employee")]
        public IActionResult Work3()
        {
            return View("Work3");
        }
    }
}
