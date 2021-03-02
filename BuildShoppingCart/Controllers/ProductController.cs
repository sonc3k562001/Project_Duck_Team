using BuildShoppingCart.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BuildShoppingCart.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {

        private mydbContext db = new mydbContext();

        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.products = db.Products.ToList();
            return View();
        }
    }
}
