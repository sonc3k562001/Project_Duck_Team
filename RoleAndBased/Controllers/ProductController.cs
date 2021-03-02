using Microsoft.AspNetCore.Mvc;
using RoleAndBased.Models;
using System.Linq;



namespace RoleAndBased.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {

        private mydbContext db = new mydbContext();
        public IActionResult Index()
        {
            ViewBag.products = db.Products.ToList();
            return View();
        }
    }
}

