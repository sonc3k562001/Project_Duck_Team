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
            
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                ViewBag.cart = cart;
                ViewBag.Count = cart.Count;
            }

            return View();
        }

        public IActionResult Bracelets(string searchString, string color, string metal, string brand, string dim, string stone)
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                ViewBag.cart = cart;
                ViewBag.Count = cart.Count;
            }
            var category = _context.Category.FirstOrDefault(x => x.TypeName == "Bracelets");
            List<Product> products = _context.Product.Where(x => x.IdCategory == category.IdCategory).ToList();

            List<Color> colors = _context.Color.ToList();
            List<Metal> metals = _context.Metal.ToList();
            List<Dim> dims = _context.Dim.ToList();
            List<Stone> stones = _context.Stone.ToList();
            List<Brand> brands = _context.Brand.ToList();
            ViewBag.colors = colors;
            ViewBag.metals = metals;
            ViewBag.dims = dims;
            ViewBag.stones = stones;
            ViewBag.brands = brands;

            if (searchString != null)
            {
                products = products.Where(x => x.Name == searchString || x.PdId == searchString || x.StoneId == searchString || x.DimId == searchString || x.BrandId == searchString || x.ColorId == searchString).ToList();
            }
            if (color != null || stone != null || dim != null || metal != null || brand != null)
            {
                products = products.Where(x => x.ColorId == color || x.BrandId == brand || x.DimId == dim || x.StoneId == stone || x.MetalId == metal).ToList();
            }
            if (products.Count == 0)
            {
                ViewBag.message = "Can't find the product you need";
            }

            return View(products);
        }

        public IActionResult Lockets(string searchString,string color,string metal,string brand,string dim,string stone)
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                ViewBag.cart = cart;
                ViewBag.Count = cart.Count;
            }
            var category = _context.Category.FirstOrDefault(x => x.TypeName == "Lockets");// get categorry
            List<Product> products = _context.Product.Where(x => x.IdCategory == category.IdCategory).ToList();// list product in category

            List<Color> colors = _context.Color.ToList();
            List<Metal> metals = _context.Metal.ToList();
            List<Dim> dims = _context.Dim.ToList();
            List<Stone> stones = _context.Stone.ToList();
            List<Brand> brands = _context.Brand.ToList();
            ViewBag.colors = colors;
            ViewBag.metals = metals;
            ViewBag.dims = dims;
            ViewBag.stones = stones;
            ViewBag.brands = brands;

            if (searchString != null)
            {
                products = products.Where(x => x.Name ==searchString || x.PdId == searchString || x.StoneId == searchString|| x.DimId == searchString|| x.BrandId == searchString|| x.ColorId == searchString).ToList();
            }
            if(color != null ||stone != null || dim != null || metal != null || brand != null)
            {
                products = products.Where(x => x.ColorId == color || x.BrandId == brand|| x.DimId == dim|| x.StoneId == stone|| x.MetalId == metal).ToList();
            }
            if(products.Count == 0)
            {
                ViewBag.message = "Can't find the product you need";
            }
            return View(products);
        }

        public IActionResult Necklaces(string searchString, string color, string metal, string brand, string dim, string stone)
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                ViewBag.cart = cart;
                ViewBag.Count = cart.Count;
            }
            var category = _context.Category.FirstOrDefault(x => x.TypeName == "Necklaces");
            List<Product> products = _context.Product.Where(x => x.IdCategory == category.IdCategory).ToList();


            List<Color> colors = _context.Color.ToList();
            List<Metal> metals = _context.Metal.ToList();
            List<Dim> dims = _context.Dim.ToList();
            List<Stone> stones = _context.Stone.ToList();
            List<Brand> brands = _context.Brand.ToList();
            ViewBag.colors = colors;
            ViewBag.metals = metals;
            ViewBag.dims = dims;
            ViewBag.stones = stones;
            ViewBag.brands = brands;

            if (searchString != null)
            {
                products = products.Where(x => x.Name == searchString || x.PdId == searchString || x.StoneId == searchString || x.DimId == searchString || x.BrandId == searchString || x.ColorId == searchString).ToList();
            }
            if (color != null || stone != null || dim != null || metal != null || brand != null)
            {
                products = products.Where(x => x.ColorId == color || x.BrandId == brand || x.DimId == dim || x.StoneId == stone || x.MetalId == metal).ToList();
            }
            if (products.Count == 0)
            {
                ViewBag.message = "Can't find the product you need";
            }
            return View(products);
        }
        public IActionResult Rings(string searchString, string color, string metal, string brand, string dim, string stone)
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                ViewBag.cart = cart;
                ViewBag.Count = cart.Count;
            }
            var category = _context.Category.FirstOrDefault(x => x.TypeName == "Rings");
            List<Product> products = _context.Product.Where(x => x.IdCategory == category.IdCategory).ToList();

            List<Color> colors = _context.Color.ToList();
            List<Metal> metals = _context.Metal.ToList();
            List<Dim> dims = _context.Dim.ToList();
            List<Stone> stones = _context.Stone.ToList();
            List<Brand> brands = _context.Brand.ToList();
            ViewBag.colors = colors;
            ViewBag.metals = metals;
            ViewBag.dims = dims;
            ViewBag.stones = stones;
            ViewBag.brands = brands;

            if (searchString != null)
            {
                products = products.Where(x => x.Name == searchString || x.PdId == searchString || x.StoneId == searchString || x.DimId == searchString || x.BrandId == searchString || x.ColorId == searchString).ToList();
            }
            if (color != null || stone != null || dim != null || metal != null || brand != null)
            {
                products = products.Where(x => x.ColorId == color || x.BrandId == brand || x.DimId == dim || x.StoneId == stone || x.MetalId == metal).ToList();
            }
            if (products.Count == 0)
            {
                ViewBag.message = "Can't find the product you need";
            }
            return View(products);
        }
        public IActionResult Earrings(string searchString, string color, string metal, string brand, string dim, string stone)
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                ViewBag.cart = cart;
                ViewBag.Count = cart.Count;
            }
            var category = _context.Category.FirstOrDefault(x => x.TypeName == "Earrings");
            List<Product> products = _context.Product.Where(x => x.IdCategory == category.IdCategory).ToList();



            List<Color> colors = _context.Color.ToList();
            List<Metal> metals = _context.Metal.ToList();
            List<Dim> dims = _context.Dim.ToList();
            List<Stone> stones = _context.Stone.ToList();
            List<Brand> brands = _context.Brand.ToList();
            ViewBag.colors = colors;
            ViewBag.metals = metals;
            ViewBag.dims = dims;
            ViewBag.stones = stones;
            ViewBag.brands = brands;

            if (searchString != null)
            {
                products = products.Where(x => x.Name == searchString || x.PdId == searchString || x.StoneId == searchString || x.DimId == searchString || x.BrandId == searchString || x.ColorId == searchString).ToList();
            }
            if (color != null || stone != null || dim != null || metal != null || brand != null)
            {
                products = products.Where(x => x.ColorId == color || x.BrandId == brand || x.DimId == dim || x.StoneId == stone || x.MetalId == metal).ToList();
            }
            if (products.Count == 0)
            {
                ViewBag.message = "Can't find the product you need";
            }
            return View(products);
        }

        public IActionResult Product_detail(string id)
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                ViewBag.cart = cart;
                ViewBag.Count = cart.Count;
            }
            if (id == null)
            {
                return NotFound();
            }

            var product = _context.Product.FirstOrDefault(m => m.PdId == id);
            if (product == null)
            {
                return NotFound();
            }
            Category category = _context.Category.FirstOrDefault(x => x.IdCategory == product.IdCategory);
            Color color = _context.Color.FirstOrDefault(x => x.ColorId == product.ColorId);
            Brand brand = _context.Brand.FirstOrDefault(x => x.BrandId == product.BrandId);
            Dim dim = _context.Dim.FirstOrDefault(x => x.DimId == product.DimId);
            Stone stone = _context.Stone.FirstOrDefault(x => x.StoneId == product.StoneId);

            List<Product> productWithcate = new List<Product>();
            Product[] productsArr = _context.Product.Where(x => x.IdCategory == category.IdCategory).ToArray();

            for (int i = 0; i < 4; i++)
            {
                if (i + 1 > productsArr.Length)
                {
                    break;
                }
                productWithcate.Add(productsArr[i]);
            }

            ViewBag.category = category;
            ViewBag.color = color;
            ViewBag.brand = brand;
            ViewBag.dim = dim;
            ViewBag.stone = stone;

            ViewBag.productWithCategory = productWithcate;
            ViewData["Descirption"] = product.Description;
            ViewBag.product = product;
            return View(product);
        }
        public IActionResult Bestsellers()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                ViewBag.cart = cart;
                ViewBag.Count = cart.Count;
            }

            List<OrderDetail> orderDetails = _context.OrderDetail.ToList();
            List<Product> products = _context.Product.ToList();
            List<Item> items = new List<Item>();

            foreach (Product product in products)
            {
                List<OrderDetail> listOrderDetail = orderDetails.Where(x => x.PdId == product.PdId).ToList();
                int SumQty = 0;
                foreach (OrderDetail orderdetail in listOrderDetail)
                {
                    SumQty += orderdetail.Quantity;
                }
                Item item = new Item();
                item.Quantity = SumQty;
                item.Product = product;
                items.Add(item);
            }


            var max = 0;
            List<int> listqty = new List<int>();
            foreach (Item item in items)
            {
                listqty.Add(item.Quantity);
                if (max <= item.Quantity)
                {
                    max = item.Quantity;
                }
            }
            listqty.Sort();

            int[] qtyarr = listqty.ToArray();
            

            int n, i, j, tmp;

            for (i = 0; i < qtyarr.Length; i++)
            {
                for (j = i + 1; j < qtyarr.Length; j++)
                {
                    if (qtyarr[i] < qtyarr[j])
                    {
                        tmp = qtyarr[i];
                        qtyarr[i] = qtyarr[j];
                        qtyarr[j] = tmp;
                    }
                }
            }

            List<Item> bestsell = items.Where(x => x.Quantity == qtyarr[0] || x.Quantity == qtyarr[1]|| x.Quantity == qtyarr[2]).ToList();
            ViewBag.best = bestsell;
            return View(bestsell);
        }

    }
}
