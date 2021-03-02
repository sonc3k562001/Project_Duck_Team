using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private Models.AppContext _context;

        public ProductController()
        {
            _context = new Models.AppContext();
        }

        public IActionResult Index()
        {
            return View();
        }
        public ActionResult ProductList()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        public ActionResult ProductInfo()
        {
            return View(new Product { ProductID = 0 });
        }


        public ActionResult SaveProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View("Product Info", product);
            }
            if (product.ProductID == 0)
            {
                _context.Products.Add(product);
            }
            else
            {
                var productFromDb = _context.Products.FirstOrDefault(e => e.ProductID == product.ProductID);
                if (productFromDb == null)
                    return View("Not Found - Son dz");
                productFromDb.Name = product.Name;
                productFromDb.Category = product.Category;
                productFromDb.Price = product.Price;
                productFromDb.Image = product.Image;
            }
            _context.SaveChanges();
            return RedirectToAction("Product List");
        }

        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return View("Not Found - Son Dz");
            }

            var product = _context.Products.FirstOrDefault(e => e.ProductID == id);
            if (product == null)
            {
                return View("Not Found - Son Dz");
            }
            return View("Product Infor", product);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return View("Note Found - But Son Dz");
            }

            var product = _context.Products.FirstOrDefault(e => e.ProductID == id);

            if (product == null)
            {
                return View("Note Found - But Son Dz");
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("Product List");

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}
