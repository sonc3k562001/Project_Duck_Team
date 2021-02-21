using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjectTeamVitAspDotNetCore.Controllers
{
    public class AdminManager : Controller
    {
        [Authorize(Roles = "Admin,SuperAdmin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
