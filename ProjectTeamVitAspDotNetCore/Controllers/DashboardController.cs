using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectTeamVitAspDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTeamVitAspDotNetCore.Controllers
{
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class DashboardController : Controller
    {
        private JwelleryContext db = new JwelleryContext();
        public IActionResult Index()
        {
            List<User> users = db.User.ToList();
            int UserCount = 0;
            foreach(User user in users)
            {
                UserCount++;
            }
            ViewBag.totalUser = UserCount;

            List<Product> products = db.Product.ToList();
            int ProductCount = 0;
            foreach (Product product in products)
            {
                ProductCount++;
            }
            ViewBag.totalProduct = ProductCount;

            List<Order> orders = db.Order.ToList();
            int OrderCount = 0;
            foreach (Order order in orders)
            {
                OrderCount++;
            }
            ViewBag.totalOrder = OrderCount;

            return View();
        }
    }
}
