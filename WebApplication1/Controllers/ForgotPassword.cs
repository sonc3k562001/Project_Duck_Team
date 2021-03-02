using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ForgotPassword : Controller
    {
        [Route("Indentity/Account/ForgotPassword")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
