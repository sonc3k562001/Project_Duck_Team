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
    public class DimQltySubMstsController : Controller
    {
        private readonly DuckTeamProjectContext _context;

        public DimQltySubMstsController(DuckTeamProjectContext context)
        {
            _context = context;
        }

        // GET: DimQltySubMsts
        public async Task<IActionResult> Index()
        {
            return View(await _context.DimQltySubMst.ToListAsync());
        }

        // GET: DimQltySubMsts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimQltySubMst = await _context.DimQltySubMst
                .FirstOrDefaultAsync(m => m.DimSubTypeId == id);
            if (dimQltySubMst == null)
            {
                return NotFound();
            }

            return View(dimQltySubMst);
        }

        // GET: DimQltySubMsts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DimQltySubMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DimSubTypeId,DimQlty")] DimQltySubMst dimQltySubMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dimQltySubMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dimQltySubMst);
        }

        // GET: DimQltySubMsts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimQltySubMst = await _context.DimQltySubMst.FindAsync(id);
            if (dimQltySubMst == null)
            {
                return NotFound();
            }
            return View(dimQltySubMst);
        }

        // POST: DimQltySubMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DimSubTypeId,DimQlty")] DimQltySubMst dimQltySubMst)
        {
            if (id != dimQltySubMst.DimSubTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dimQltySubMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DimQltySubMstExists(dimQltySubMst.DimSubTypeId))
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
            return View(dimQltySubMst);
        }

        // GET: DimQltySubMsts/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimQltySubMst = await _context.DimQltySubMst
                .FirstOrDefaultAsync(m => m.DimSubTypeId == id);
            if (dimQltySubMst == null)
            {
                return NotFound();
            }

            return View(dimQltySubMst);
        }

        // POST: DimQltySubMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var dimQltySubMst = await _context.DimQltySubMst.FindAsync(id);
            _context.DimQltySubMst.Remove(dimQltySubMst);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DimQltySubMstExists(string id)
        {
            return _context.DimQltySubMst.Any(e => e.DimSubTypeId == id);
        }
    }
}
