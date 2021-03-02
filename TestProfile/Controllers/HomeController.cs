using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestProfile.Helpers;
using TestProfile.Models;

namespace TestProfile.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var Email = "skjfjksfjkskjf";
            HttpContext.Session.SetString("key",Email); // Set Session  
            var x = HttpContext.Session.GetString("key"); // Get Value of Session
            ViewBag.x = x;
            return View();
        }

        public IActionResult Index1()
        {
            var x = HttpContext.Session.GetString("key"); // Get Value of Session
            ViewBag.x = x;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
