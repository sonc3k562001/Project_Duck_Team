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

        public async Task<IActionResult> Bracelets(string searchString, int? pageNumber, string sortOrder,string currentFilter, string currentColor, string currentMetal, string currentBrand, string currentDim, string currentStone, string color, string metal, string brand, string dim, string stone)
        {

            ViewData["CurrentSort"] = sortOrder;
            ViewData["DateSortParm"] = sortOrder == "price" ? "price_desc" : "price";

            if (searchString != null ||color != null ||brand!=null||metal!=null||dim!=null||stone!=null)
            {
                pageNumber = 1;
            }
            else
            {
                color = currentColor;
                brand = currentBrand;
                dim = currentDim;
                stone = currentStone;
                metal = currentMetal;
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            ViewData["Color"] = color;
            ViewData["Metal"] = metal;
            ViewData["Brand"] = brand;
            ViewData["Dim"] = dim;
            ViewData["Stone"] = stone;

            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");


            if (cart != null)
            {
                ViewBag.cart = cart;
                ViewBag.Count = cart.Count;
            }
            var category = _context.Category.FirstOrDefault(x => x.TypeName.Equals("Bracelets"));
            var products = from s in _context.Product where(s.IdCategory ==category.IdCategory) select s; ;

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

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.Contains(searchString) || s.PdId.Contains(searchString) ||s.Stone.StoneId.Contains(searchString)||s.Metal.MetalId.Contains(searchString)||s.Color.ColorId.Contains(searchString)||s.Dim.DimId.Contains(searchString)||s.Brand.BrandId.Contains(searchString));
            }
            if (!String.IsNullOrEmpty(color))
            {
                products = products.Where(x => x.ColorId == color);
            }
            if (!String.IsNullOrEmpty(metal))
            {
                products = products.Where(x => x.MetalId == metal);
            }
            if (!String.IsNullOrEmpty(dim))
            {
                products = products.Where(x => x.DimId == dim);
            }
            if (!String.IsNullOrEmpty(stone))
            {
                products = products.Where(x => x.StoneId == stone);
            }
            if (!String.IsNullOrEmpty(brand))
            {
                products = products.Where(x => x.BrandId == brand);
            }
            if (products.Count() == 0)
            {
                ViewBag.message = "Can't find the product you need";
            }


            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.Contains(searchString) || s.Category.TypeName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "price":
                    products = products.OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.OrderBy(s => s.PdId);
                    break;
            }

            int pageSize = 8;
            ViewBag.pageSize = pageSize;
            ViewBag.CountP = products.Count();
            ViewBag.order = sortOrder;

            return View(await PaginatedList<Product>.CreateAsync(products.AsNoTracking(), pageNumber ?? 1, pageSize));
        }
        public async Task<IActionResult> Lockets(string searchString, int? pageNumber, string sortOrder,string currentFilter, string currentColor, string currentMetal, string currentBrand, string currentDim, string currentStone, string color, string metal, string brand, string dim, string stone)
        {

            ViewData["CurrentSort"] = sortOrder;
            ViewData["DateSortParm"] = sortOrder == "price" ? "price_desc" : "price";

            if (searchString != null ||color != null ||brand!=null||metal!=null||dim!=null||stone!=null)
            {
                pageNumber = 1;
            }
            else
            {
                color = currentColor;
                brand = currentBrand;
                dim = currentDim;
                stone = currentStone;
                metal = currentMetal;
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            ViewData["Color"] = color;
            ViewData["Metal"] = metal;
            ViewData["Brand"] = brand;
            ViewData["Dim"] = dim;
            ViewData["Stone"] = stone;

            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                ViewBag.cart = cart;
                ViewBag.Count = cart.Count;
            }
            var category = _context.Category.FirstOrDefault(x => x.TypeName.Equals("Lockets"));
            var products = from s in _context.Product where(s.IdCategory ==category.IdCategory) select s; ;

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

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.Contains(searchString) || s.PdId.Contains(searchString) ||s.Stone.StoneId.Contains(searchString)||s.Metal.MetalId.Contains(searchString)||s.Color.ColorId.Contains(searchString)||s.Dim.DimId.Contains(searchString)||s.Brand.BrandId.Contains(searchString));
            }
            if (!String.IsNullOrEmpty(color))
            {
                products = products.Where(x => x.ColorId == color);
            }
            if (!String.IsNullOrEmpty(metal))
            {
                products = products.Where(x => x.MetalId == metal);
            }
            if (!String.IsNullOrEmpty(dim))
            {
                products = products.Where(x => x.DimId == dim);
            }
            if (!String.IsNullOrEmpty(stone))
            {
                products = products.Where(x => x.StoneId == stone);
            }
            if (!String.IsNullOrEmpty(brand))
            {
                products = products.Where(x => x.BrandId == brand);
            }
            if (products.Count() == 0)
            {
                ViewBag.message = "Can't find the product you need";
            }


            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.Contains(searchString) || s.Category.TypeName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "price":
                    products = products.OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.OrderBy(s => s.PdId);
                    break;
            }

            int pageSize = 8;
            ViewBag.pageSize = pageSize;
            ViewBag.CountP = products.Count();
            ViewBag.order = sortOrder;

            return View(await PaginatedList<Product>.CreateAsync(products.AsNoTracking(), pageNumber ?? 1, pageSize));
        }
        public async Task<IActionResult> Necklaces(string searchString, int? pageNumber, string sortOrder,string currentFilter, string currentColor, string currentMetal, string currentBrand, string currentDim, string currentStone, string color, string metal, string brand, string dim, string stone)
        {

            ViewData["CurrentSort"] = sortOrder;
            ViewData["DateSortParm"] = sortOrder == "price" ? "price_desc" : "price";

            if (searchString != null ||color != null ||brand!=null||metal!=null||dim!=null||stone!=null)
            {
                pageNumber = 1;
            }
            else
            {
                color = currentColor;
                brand = currentBrand;
                dim = currentDim;
                stone = currentStone;
                metal = currentMetal;
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            ViewData["Color"] = color;
            ViewData["Metal"] = metal;
            ViewData["Brand"] = brand;
            ViewData["Dim"] = dim;
            ViewData["Stone"] = stone;

            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                ViewBag.cart = cart;
                ViewBag.Count = cart.Count;
            }
            var category = _context.Category.FirstOrDefault(x => x.TypeName.Equals("Necklaces"));
            var products = from s in _context.Product where(s.IdCategory ==category.IdCategory) select s; ;

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

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.Contains(searchString) || s.PdId.Contains(searchString) ||s.Stone.StoneId.Contains(searchString)||s.Metal.MetalId.Contains(searchString)||s.Color.ColorId.Contains(searchString)||s.Dim.DimId.Contains(searchString)||s.Brand.BrandId.Contains(searchString));
            }
            if (!String.IsNullOrEmpty(color))
            {
                products = products.Where(x => x.ColorId == color);
            }
            if (!String.IsNullOrEmpty(metal))
            {
                products = products.Where(x => x.MetalId == metal);
            }
            if (!String.IsNullOrEmpty(dim))
            {
                products = products.Where(x => x.DimId == dim);
            }
            if (!String.IsNullOrEmpty(stone))
            {
                products = products.Where(x => x.StoneId == stone);
            }
            if (!String.IsNullOrEmpty(brand))
            {
                products = products.Where(x => x.BrandId == brand);
            }
            if (products.Count() == 0)
            {
                ViewBag.message = "Can't find the product you need";
            }


            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.Contains(searchString) || s.Category.TypeName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "price":
                    products = products.OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.OrderBy(s => s.PdId);
                    break;
            }

            int pageSize = 8;
            ViewBag.pageSize = pageSize;
            ViewBag.CountP = products.Count();
            ViewBag.order = sortOrder;

            return View(await PaginatedList<Product>.CreateAsync(products.AsNoTracking(), pageNumber ?? 1, pageSize));
        }
        public async Task<IActionResult> Rings(string searchString, int? pageNumber, string sortOrder,string currentFilter, string currentColor, string currentMetal, string currentBrand, string currentDim, string currentStone, string color, string metal, string brand, string dim, string stone)
        {

            ViewData["CurrentSort"] = sortOrder;
            ViewData["DateSortParm"] = sortOrder == "price" ? "price_desc" : "price";

            if (searchString != null ||color != null ||brand!=null||metal!=null||dim!=null||stone!=null)
            {
                pageNumber = 1;
            }
            else
            {
                color = currentColor;
                brand = currentBrand;
                dim = currentDim;
                stone = currentStone;
                metal = currentMetal;
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            ViewData["Color"] = color;
            ViewData["Metal"] = metal;
            ViewData["Brand"] = brand;
            ViewData["Dim"] = dim;
            ViewData["Stone"] = stone;

            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                ViewBag.cart = cart;
                ViewBag.Count = cart.Count;
            }
            var category = _context.Category.FirstOrDefault(x => x.TypeName.Equals("Rings"));
            var products = from s in _context.Product where(s.IdCategory ==category.IdCategory) select s; ;

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

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.Contains(searchString) || s.PdId.Contains(searchString) ||s.Stone.StoneId.Contains(searchString)||s.Metal.MetalId.Contains(searchString)||s.Color.ColorId.Contains(searchString)||s.Dim.DimId.Contains(searchString)||s.Brand.BrandId.Contains(searchString));
            }
            if (!String.IsNullOrEmpty(color))
            {
                products = products.Where(x => x.ColorId == color);
            }
            if (!String.IsNullOrEmpty(metal))
            {
                products = products.Where(x => x.MetalId == metal);
            }
            if (!String.IsNullOrEmpty(dim))
            {
                products = products.Where(x => x.DimId == dim);
            }
            if (!String.IsNullOrEmpty(stone))
            {
                products = products.Where(x => x.StoneId == stone);
            }
            if (!String.IsNullOrEmpty(brand))
            {
                products = products.Where(x => x.BrandId == brand);
            }
            if (products.Count() == 0)
            {
                ViewBag.message = "Can't find the product you need";
            }


            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.Contains(searchString) || s.Category.TypeName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "price":
                    products = products.OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.OrderBy(s => s.PdId);
                    break;
            }

            int pageSize = 8;
            ViewBag.pageSize = pageSize;
            ViewBag.CountP = products.Count();
            ViewBag.order = sortOrder;

            return View(await PaginatedList<Product>.CreateAsync(products.AsNoTracking(), pageNumber ?? 1, pageSize));
        }
        public async Task<IActionResult> Earrings(string searchString, int? pageNumber, string sortOrder,string currentFilter, string currentColor, string currentMetal, string currentBrand, string currentDim, string currentStone, string color, string metal, string brand, string dim, string stone)
        {

            ViewData["CurrentSort"] = sortOrder;
            ViewData["DateSortParm"] = sortOrder == "price" ? "price_desc" : "price";

            if (searchString != null ||color != null ||brand!=null||metal!=null||dim!=null||stone!=null)
            {
                pageNumber = 1;
            }
            else
            {
                color = currentColor;
                brand = currentBrand;
                dim = currentDim;
                stone = currentStone;
                metal = currentMetal;
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            ViewData["Color"] = color;
            ViewData["Metal"] = metal;
            ViewData["Brand"] = brand;
            ViewData["Dim"] = dim;
            ViewData["Stone"] = stone;

            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                ViewBag.cart = cart;
                ViewBag.Count = cart.Count;
            }
            var category = _context.Category.FirstOrDefault(x => x.TypeName.Equals("Earrings"));
            var products = from s in _context.Product where(s.IdCategory ==category.IdCategory) select s; ;

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

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.Contains(searchString) || s.PdId.Contains(searchString) ||s.Stone.StoneId.Contains(searchString)||s.Metal.MetalId.Contains(searchString)||s.Color.ColorId.Contains(searchString)||s.Dim.DimId.Contains(searchString)||s.Brand.BrandId.Contains(searchString));
            }
            if (!String.IsNullOrEmpty(color))
            {
                products = products.Where(x => x.ColorId == color);
            }
            if (!String.IsNullOrEmpty(metal))
            {
                products = products.Where(x => x.MetalId == metal);
            }
            if (!String.IsNullOrEmpty(dim))
            {
                products = products.Where(x => x.DimId == dim);
            }
            if (!String.IsNullOrEmpty(stone))
            {
                products = products.Where(x => x.StoneId == stone);
            }
            if (!String.IsNullOrEmpty(brand))
            {
                products = products.Where(x => x.BrandId == brand);
            }
            if (products.Count() == 0)
            {
                ViewBag.message = "Can't find the product you need";
            }


            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.Contains(searchString) || s.Category.TypeName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "price":
                    products = products.OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.OrderByDescending(s => s.Price);
                    break;
                default:
                    products = products.OrderBy(s => s.PdId);
                    break;
            }

            int pageSize = 8;
            ViewBag.pageSize = pageSize;
            ViewBag.CountP = products.Count();
            ViewBag.order = sortOrder;

            return View(await PaginatedList<Product>.CreateAsync(products.AsNoTracking(), pageNumber ?? 1, pageSize));
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
            ViewBag.link = product.IdCategory;
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
