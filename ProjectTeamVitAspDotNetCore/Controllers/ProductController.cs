using Microsoft.AspNetCore.Mvc;
using ProjectTeamVitAspDotNetCore.Helpers;
using ProjectTeamVitAspDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTeamVitAspDotNetCore.Controllers
{
    public class ProductController : Controller
    {
        private readonly JwelleryContext _context;

        public ProductController(JwelleryContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View();
        }
        
        public async Task<IActionResult> Bracelets()
        {
            var category = _context.Category.FirstOrDefault(x => x.TypeName == "Bracelets");
            List<Product> products = _context.Product.Where(x=>x.IdCategory == category.IdCategory).ToList();
            return View(products);
        }

        public IActionResult Lockets()
        {
            var category = _context.Category.FirstOrDefault(x => x.TypeName == "Lockets");
            List<Product> products = _context.Product.Where(x => x.IdCategory == category.IdCategory).ToList();
            return View(products);
        }

        public IActionResult Necklaces()
        {
            var category = _context.Category.FirstOrDefault(x => x.TypeName == "Necklaces");
            List<Product> products = _context.Product.Where(x => x.IdCategory == category.IdCategory).ToList();
            return View(products);
        }
        public IActionResult Rings()
        {
            var category = _context.Category.FirstOrDefault(x => x.TypeName == "Rings");
            List<Product> products = _context.Product.Where(x => x.IdCategory == category.IdCategory).ToList();
            return View(products);
        }
        public IActionResult Earrings()
        {
            var category = _context.Category.FirstOrDefault(x => x.TypeName == "Earrings");
            List<Product> products = _context.Product.Where(x => x.IdCategory == category.IdCategory).ToList();
            return View(products);
        }

        public IActionResult Product_detail(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product =  _context.Product.FirstOrDefault(m => m.PdId == id);
            if (product == null)
            {
                return NotFound();
            }
            ViewBag.product = product;
            return View(product);
        }
        public IActionResult Product_list()
        {
            return View();
        }

    }
}
