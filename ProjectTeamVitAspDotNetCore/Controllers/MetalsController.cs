using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectTeamVitAspDotNetCore.Models;

namespace ProjectTeamVitAspDotNetCore.Controllers
{
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class MetalsController : Controller
    {
        private readonly JwelleryContext _context;

        public MetalsController(JwelleryContext context)
        {
            _context = context;
        }

        // GET: Metals
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
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
            var metals = from s in _context.Metal select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                metals = metals.Where(s => s.Name.Contains(searchString) || s.MetalId.Contains(searchString) );
            }
            switch (sortOrder)
            {
                case "name_desc":
                    metals = metals.OrderByDescending(s => s.Name);
                    break;
                case "name":
                    metals = metals.OrderBy(s => s.Name);
                    break;
                default:
                    metals = metals.OrderBy(s => s.MetalId);
                    break;
            }

            int pageSize = 10;
            ViewBag.pageSize = pageSize;
            ViewBag.Count = metals.Count();
            ViewBag.order = sortOrder;
            return View(await PaginatedList<Metal>.CreateAsync(metals.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: Metals/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var metal = await _context.Metal
                .FirstOrDefaultAsync(m => m.MetalId == id);
            if (metal == null)
            {
                return NotFound();
            }

            return View(metal);
        }

        // GET: Metals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Metals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MetalId,Name,MetalCrt")] Metal metal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(metal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(metal);
        }

        // GET: Metals/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var metal = await _context.Metal.FindAsync(id);
            if (metal == null)
            {
                return NotFound();
            }
            return View(metal);
        }

        // POST: Metals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MetalId,Name,MetalCrt")] Metal metal)
        {
            if (id != metal.MetalId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(metal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MetalExists(metal.MetalId))
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
            return View(metal);
        }

        // GET: Metals/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var metal = await _context.Metal
                .FirstOrDefaultAsync(m => m.MetalId == id);
            if (metal == null)
            {
                return NotFound();
            }

            return View(metal);
        }

        // POST: Metals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var metal = await _context.Metal.FindAsync(id);
            _context.Metal.Remove(metal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MetalExists(string id)
        {
            return _context.Metal.Any(e => e.MetalId == id);
        }
    }
}
