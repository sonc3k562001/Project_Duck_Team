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
    [Authorize(Roles = "Admin,SuperAdmin,Employee")]
    public class DimsController : Controller
    {
        private readonly JwelleryContext _context;

        public DimsController(JwelleryContext context)
        {
            _context = context;
        }

        // GET: Dims
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
            var dims = from s in _context.Dim select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                dims = dims.Where(s => s.Name.Contains(searchString) || s.DimId.Contains(searchString)|| s.Certify.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "price":
                    dims = dims.OrderBy(s => s.DimRate);
                    break;
                case "price_desc":
                    dims = dims.OrderByDescending(s => s.DimRate);
                    break;
                case "name_desc":
                    dims = dims.OrderByDescending(s => s.Name);
                    break;
                case "name":
                    dims = dims.OrderBy(s => s.Name);
                    break;
                default:
                    dims = dims.OrderBy(s => s.DimId);
                    break;
            }

            int pageSize = 10;
            ViewBag.pageSize = pageSize;
            ViewBag.Count = dims.Count();
            ViewBag.order = sortOrder;
            return View(await PaginatedList<Dim>.CreateAsync(dims.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: Dims/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dim = await _context.Dim
                .FirstOrDefaultAsync(m => m.DimId == id);
            if (dim == null)
            {
                return NotFound();
            }

            return View(dim);
        }

        // GET: Dims/Create
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DimId,Name,DimCrt,DimPcs,DimGm,DimRate,DimAmt,Certify,DimSize")] Dim dim)
        {

            var value = _context.Dim.FirstOrDefault(x => x.DimId == dim.DimId);
            {
                ViewBag.Error = "Diamond code already exists";
                return View();
            }

            if (ModelState.IsValid)
            {
                _context.Add(dim);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dim);
        }

        // GET: Dims/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dim = await _context.Dim.FindAsync(id);
            if (dim == null)
            {
                return NotFound();
            }
            return View(dim);
        }

        // POST: Dims/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DimId,Name,DimCrt,DimPcs,DimGm,DimRate,DimAmt,Certify,DimSize")] Dim dim)
        {
            if (id != dim.DimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dim);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DimExists(dim.DimId))
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
            return View(dim);
        }

        // GET: Dims/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dim = await _context.Dim
                .FirstOrDefaultAsync(m => m.DimId == id);
            if (dim == null)
            {
                return NotFound();
            }

            return View(dim);
        }

        // POST: Dims/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var dim = await _context.Dim.FindAsync(id);
            _context.Dim.Remove(dim);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DimExists(string id)
        {
            return _context.Dim.Any(e => e.DimId == id);
        }
    }
}
