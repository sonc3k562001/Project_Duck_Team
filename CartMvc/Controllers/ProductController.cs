using CartMvc.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CartMvc.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            ProductModel productModel = new ProductModel();
            ViewBag.products = productModel.findAll();
            return View();
        }
    }
}
