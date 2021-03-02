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
    public class DimMstsController : Controller
    {
        private readonly DuckTeamProjectContext _context;

        public DimMstsController(DuckTeamProjectContext context)
        {
            _context = context;
        }

        // GET: DimMsts
        public async Task<IActionResult> Index()
        {
            var duckTeamProjectContext = _context.DimMst.Include(d => d.DimQlty).Include(d => d.DimSubType).Include(d => d.StyleCodeNavigation);
            return View(await duckTeamProjectContext.ToListAsync());
        }

        // GET: DimMsts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimMst = await _context.DimMst
                .Include(d => d.DimQlty)
                .Include(d => d.DimSubType)
                .Include(d => d.StyleCodeNavigation)
                .FirstOrDefaultAsync(m => m.StyleCode == id);
            if (dimMst == null)
            {
                return NotFound();
            }

            return View(dimMst);
        }

        // GET: DimMsts/Create
        public IActionResult Create()
        {
            ViewData["DimQltyId"] = new SelectList(_context.DimQltyMst, "DimQltyId", "DimQltyId");
            ViewData["DimSubTypeId"] = new SelectList(_context.DimQltySubMst, "DimSubTypeId", "DimSubTypeId");
            ViewData["StyleCode"] = new SelectList(_context.ItemMst, "StyleCode", "StyleCode");
            return View();
        }

        // POST: DimMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StyleCode,DimQltyId,DimSubTypeId,DimCrt,DimPcs,DimGm,DimSize,DimRate,DimAmt")] DimMst dimMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dimMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DimQltyId"] = new SelectList(_context.DimQltyMst, "DimQltyId", "DimQltyId", dimMst.DimQltyId);
            ViewData["DimSubTypeId"] = new SelectList(_context.DimQltySubMst, "DimSubTypeId", "DimSubTypeId", dimMst.DimSubTypeId);
            ViewData["StyleCode"] = new SelectList(_context.ItemMst, "StyleCode", "StyleCode", dimMst.StyleCode);
            return View(dimMst);
        }

        // GET: DimMsts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimMst = await _context.DimMst.FindAsync(id);
            if (dimMst == null)
            {
                return NotFound();
            }
            ViewData["DimQltyId"] = new SelectList(_context.DimQltyMst, "DimQltyId", "DimQltyId", dimMst.DimQltyId);
            ViewData["DimSubTypeId"] = new SelectList(_context.DimQltySubMst, "DimSubTypeId", "DimSubTypeId", dimMst.DimSubTypeId);
            ViewData["StyleCode"] = new SelectList(_context.ItemMst, "StyleCode", "StyleCode", dimMst.StyleCode);
            return View(dimMst);
        }

        // POST: DimMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StyleCode,DimQltyId,DimSubTypeId,DimCrt,DimPcs,DimGm,DimSize,DimRate,DimAmt")] DimMst dimMst)
        {
            if (id != dimMst.StyleCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dimMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DimMstExists(dimMst.StyleCode))
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
            ViewData["DimQltyId"] = new SelectList(_context.DimQltyMst, "DimQltyId", "DimQltyId", dimMst.DimQltyId);
            ViewData["DimSubTypeId"] = new SelectList(_context.DimQltySubMst, "DimSubTypeId", "DimSubTypeId", dimMst.DimSubTypeId);
            ViewData["StyleCode"] = new SelectList(_context.ItemMst, "StyleCode", "StyleCode", dimMst.StyleCode);
            return View(dimMst);
        }

        // GET: DimMsts/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimMst = await _context.DimMst
                .Include(d => d.DimQlty)
                .Include(d => d.DimSubType)
                .Include(d => d.StyleCodeNavigation)
                .FirstOrDefaultAsync(m => m.StyleCode == id);
            if (dimMst == null)
            {
                return NotFound();
            }

            return View(dimMst);
        }

        // POST: DimMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var dimMst = await _context.DimMst.FindAsync(id);
            _context.DimMst.Remove(dimMst);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DimMstExists(string id)
        {
            return _context.DimMst.Any(e => e.StyleCode == id);
        }
    }
}
