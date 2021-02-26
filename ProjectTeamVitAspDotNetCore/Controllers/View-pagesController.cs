using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjectTeamVitAspDotNetCore.Controllers
{
    public class View_pagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("View_pages/affiliates")]
        public IActionResult affiliates()
        {
            return View();
        }
        public IActionResult background()
        {
            return View();
        }
        public IActionResult bestsellers()
        {
            return View();
        }
        public IActionResult careers()
        {
            return View();
        }
        public IActionResult checkout()
        {
            return View();
        }
        public IActionResult contact()
        {
            return View();
        }
        public IActionResult delivery()
        {
            return View();
        }
        public IActionResult error()
        {
            return View();
        }
        public IActionResult explore()
        {
            return View();
        }
        public IActionResult faq()
        {
            return View();
        }
        public IActionResult home()
        {
            return View();
        }
        public IActionResult new_items()
        {
            return View();
        }
        public IActionResult order_summary()
        {
            return View();
        }
        public IActionResult policy()
        {
            return View();
        }
        public IActionResult refund()
        {
            return View();
        }
        public IActionResult reviews()
        {
            return View();
        }
        public IActionResult sidenav_cart()
        {
            return View();
        }
        public IActionResult sitemap()
        {
            return View();
        }
        public IActionResult stock()
        {
            return View();
        }
        public IActionResult term()
        {
            return View();
        }
        public IActionResult thankyou()
        {
            return View();
        }

    }
}
