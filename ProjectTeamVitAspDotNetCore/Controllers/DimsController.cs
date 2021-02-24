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
    public class DimsController : Controller
    {
        private readonly JwelleryContext _context;

        public DimsController(JwelleryContext context)
        {
            _context = context;
        }

        // GET: Dims
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dim.ToListAsync());
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

        // POST: Dims/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DimId,Name,DimCrt,DimPcs,DimGm,DimRate,DimAmt,Certify,DimSize")] Dim dim)
        {
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
