using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjectTeamVitAspDotNetCore.Controllers
{
    public class AdminManager : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
