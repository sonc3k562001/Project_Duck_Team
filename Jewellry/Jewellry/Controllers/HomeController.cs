using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Jewellry.Models;

namespace Jewellry.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}


