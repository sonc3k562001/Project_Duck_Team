
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using ProjectTeamVitAspDotNetCore.Models;
using ProjectTeamVitAspDotNetCore.Models.ViewModels;

namespace ProjectTeamVitAspDotNetCore.Controllers
{
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class ProductsManagerController : Controller
    {
        private readonly JwelleryContext _context;
    
        public ProductsManagerController(JwelleryContext context)
        {
            _context = context;
          
        }

        // GET: ProductsManager

        public async Task<IActionResult> Index(string sortOrder,string currentFilter,string searchString,int? pageNumber)
        {
            ViewData["PriceSortParm"] = sortOrder == "price" ? "price_desc" : "price";
            ViewData["NameSortParm"] = sortOrder == "name" ? "name_desc" : "name";

            ViewData["CurrentFilter"] = searchString;
         

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;
            var products = from s in _context.Product select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.Contains(searchString)|| s.Category.TypeName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "price":
                    products = products.OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    products = products.OrderByDescending(s => s.Price);
                    break;
                case "name_desc":
                    products = products.OrderByDescending(s => s.Name);
                    break;
                case "name":
                    products = products.OrderBy(s => s.Name);
                    break;
                default:
                    products = products.OrderBy(s => s.PdId);
                    break;
            }

            int pageSize = 10;
            ViewBag.pageSize = pageSize;
            ViewBag.Count = products.Count();
            ViewBag.order = sortOrder;
            return View(await PaginatedList<Product>.CreateAsync(products.AsNoTracking(), pageNumber ?? 1, pageSize)); 
        }

        // GET: ProductsManager/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .Include(p => p.Color)
                .Include(p => p.Dim)
                .Include(p => p.Metal)
                .Include(p => p.Stone)
                .FirstOrDefaultAsync(m => m.PdId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: ProductsManager/Create
        public IActionResult Create()
        {
            ViewData["BrandId"] = new SelectList(_context.Brand, "BrandId", "BrandId");
            ViewData["IdCategory"] = new SelectList(_context.Category, "IdCategory", "IdCategory");
            ViewData["ColorId"] = new SelectList(_context.Color, "ColorId", "ColorId");
            ViewData["DimId"] = new SelectList(_context.Dim, "DimId", "DimId");
            ViewData["MetalId"] = new SelectList(_context.Metal, "MetalId", "MetalId");
            ViewData["StoneId"] = new SelectList(_context.Stone, "StoneId", "StoneId");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PdId,Name,Price,Description,Image,ColorId,Size,BrandId,DimId,StoneId,IdCategory,MetalId")] Product product, IFormFile Image)
        {

            var value = _context.Product.FirstOrDefault(x => x.PdId == product.PdId);
            if(value != null)
            {
                ViewBag.Error = "Product Code already exists";
                return View();
            }

            if (Image != null) { product.Image = Image.FileName; }
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                if (Image != null)
                {
                    var fileName = Path.GetFileName(Image.FileName);
                    var filepath = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images")).Root + $@"\{fileName}";

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        Image.CopyTo(fs);
                        fs.Flush();
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["BrandId"] = new SelectList(_context.Brand, "BrandId", "BrandId", product.BrandId);
            ViewData["IdCategory"] = new SelectList(_context.Category, "IdCategory", "IdCategory", product.IdCategory);
            ViewData["ColorId"] = new SelectList(_context.Color, "ColorId", "ColorId", product.ColorId);
            ViewData["DimId"] = new SelectList(_context.Dim, "DimId", "DimId", product.DimId);
            ViewData["MetalId"] = new SelectList(_context.Metal, "MetalId", "MetalId", product.MetalId);
            ViewData["StoneId"] = new SelectList(_context.Stone, "StoneId", "StoneId", product.StoneId);
            return View(product);
        }

        // GET: ProductsManager/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["BrandId"] = new SelectList(_context.Brand, "BrandId", "BrandId", product.BrandId);
            ViewData["IdCategory"] = new SelectList(_context.Category, "IdCategory", "IdCategory", product.IdCategory);
            ViewData["ColorId"] = new SelectList(_context.Color, "ColorId", "ColorId", product.ColorId);
            ViewData["DimId"] = new SelectList(_context.Dim, "DimId", "DimId", product.DimId);
            ViewData["MetalId"] = new SelectList(_context.Metal, "MetalId", "MetalId", product.MetalId);
            ViewData["StoneId"] = new SelectList(_context.Stone, "StoneId", "StoneId", product.StoneId);
            return View(product);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PdId,Name,Price,Description,Image,ColorId,Size,BrandId,DimId,StoneId,IdCategory,MetalId")] Product product)
        {
            if (id != product.PdId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.PdId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["BrandId"] = new SelectList(_context.Brand, "BrandId", "BrandId", product.BrandId);
            ViewData["IdCategory"] = new SelectList(_context.Category, "IdCategory", "IdCategory", product.IdCategory);
            ViewData["ColorId"] = new SelectList(_context.Color, "ColorId", "ColorId", product.ColorId);
            ViewData["DimId"] = new SelectList(_context.Dim, "DimId", "DimId", product.DimId);
            ViewData["MetalId"] = new SelectList(_context.Metal, "MetalId", "MetalId", product.MetalId);
            ViewData["StoneId"] = new SelectList(_context.Stone, "StoneId", "StoneId", product.StoneId);
            return View(product);
        }

        // GET: ProductsManager/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .Include(p => p.Color)
                .Include(p => p.Dim)
                .Include(p => p.Metal)
                .Include(p => p.Stone)
                .FirstOrDefaultAsync(m => m.PdId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(string id)
        {
            return _context.Product.Any(e => e.PdId == id);
        }
    }
}
