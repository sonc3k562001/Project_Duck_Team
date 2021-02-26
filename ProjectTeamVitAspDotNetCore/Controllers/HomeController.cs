using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectTeamVitAspDotNetCore.Helpers;
using ProjectTeamVitAspDotNetCore.Models;
using System.Collections.Generic;

namespace ProjectTeamVitAspDotNetCore.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                ViewBag.cart = cart;
                ViewBag.Count = cart.Count;
            }
            return View();

        }
    }
}
