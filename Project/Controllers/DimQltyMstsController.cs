using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Controllers
{
    public class DimQltyMstsController : Controller
    {
        private readonly DuckTeamProjectContext _context;

        public DimQltyMstsController(DuckTeamProjectContext context)
        {
            _context = context;
        }

        // GET: DimQltyMsts
        public async Task<IActionResult> Index()
        {
            return View(await _context.DimQltyMst.ToListAsync());
        }

        // GET: DimQltyMsts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimQltyMst = await _context.DimQltyMst
                .FirstOrDefaultAsync(m => m.DimQltyId == id);
            if (dimQltyMst == null)
            {
                return NotFound();
            }

            return View(dimQltyMst);
        }

        // GET: DimQltyMsts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DimQltyMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DimQltyId,DimQlty")] DimQltyMst dimQltyMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dimQltyMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dimQltyMst);
        }

        // GET: DimQltyMsts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimQltyMst = await _context.DimQltyMst.FindAsync(id);
            if (dimQltyMst == null)
            {
                return NotFound();
            }
            return View(dimQltyMst);
        }

        // POST: DimQltyMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DimQltyId,DimQlty")] DimQltyMst dimQltyMst)
        {
            if (id != dimQltyMst.DimQltyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dimQltyMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DimQltyMstExists(dimQltyMst.DimQltyId))
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
            return View(dimQltyMst);
        }

        // GET: DimQltyMsts/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimQltyMst = await _context.DimQltyMst
                .FirstOrDefaultAsync(m => m.DimQltyId == id);
            if (dimQltyMst == null)
            {
                return NotFound();
            }

            return View(dimQltyMst);
        }

        // POST: DimQltyMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var dimQltyMst = await _context.DimQltyMst.FindAsync(id);
            _context.DimQltyMst.Remove(dimQltyMst);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DimQltyMstExists(string id)
        {
            return _context.DimQltyMst.Any(e => e.DimQltyId == id);
        }
    }
}
