using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
