using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectTeamVitAspDotNetCore.Models;

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
        public async Task<IActionResult> Index()
        {
            var jwelleryContext = _context.Product.Include(p => p.Brand).Include(p => p.Category).Include(p => p.Color).Include(p => p.Dim).Include(p => p.Metal).Include(p => p.Stone);
            return View(await jwelleryContext.ToListAsync());
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
            if (Image != null) { product.Image = Image.FileName; }
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
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
