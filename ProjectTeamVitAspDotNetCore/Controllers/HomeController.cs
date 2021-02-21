using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjectTeamVitAspDotNetCore.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles = "Admin,Customer,SuperAdmin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
