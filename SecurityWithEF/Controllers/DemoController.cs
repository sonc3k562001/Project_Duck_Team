using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecurityWithEF.Security;

namespace SecurityWithEF.Controllers
{
    public class DemoController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [MyAuthorize(Roles = "SuperAdmin")]
        public IActionResult Work1()
        {
            return View("Work1");
        }

        [MyAuthorize(Roles = "SuperAdmin,Admin")]
        public IActionResult Work2()
        {
            return View("Work2");
        }
        [MyAuthorize(Roles = "SuperAdmin,Admin,Employee")]
        public IActionResult Work3()
        {
            return View("Work3");
        }
    }
}
