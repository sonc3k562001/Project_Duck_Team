using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using SendEmailCofirm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SendEmailCofirm.Controllers
{
    public class RegisterController : Controller
    {
        DataContext db = new DataContext();
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
