using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Jewelly.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("product/bracelet")]
        public IActionResult Bracelets()
        {
            return View();
        }

        public IActionResult Lockets()
        {
            return View();
        }

        public IActionResult Necklaces()
        {
            return View();
        }
         public IActionResult Rings()
        {
            return View();
        }

        public IActionResult Product_detail()
        {
            return View();
        }
        public IActionResult Product_list()
        {
            return View();
        }

    }
}
