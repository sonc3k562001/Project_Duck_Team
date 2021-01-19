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
    public class DimInfoMstsController : Controller
    {
        private readonly DuckTeamProjectContext _context;

        public DimInfoMstsController(DuckTeamProjectContext context)
        {
            _context = context;
        }

        // GET: DimInfoMsts
        public async Task<IActionResult> Index()
        {
            return View(await _context.DimInfoMst.ToListAsync());
        }

        // GET: DimInfoMsts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimInfoMst = await _context.DimInfoMst
                .FirstOrDefaultAsync(m => m.DimId == id);
            if (dimInfoMst == null)
            {
                return NotFound();
            }

            return View(dimInfoMst);
        }

        // GET: DimInfoMsts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DimInfoMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DimId,DimType,DimSubType,DimCrt,DimPrice,DimImg")] DimInfoMst dimInfoMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dimInfoMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dimInfoMst);
        }

        // GET: DimInfoMsts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimInfoMst = await _context.DimInfoMst.FindAsync(id);
            if (dimInfoMst == null)
            {
                return NotFound();
            }
            return View(dimInfoMst);
        }

        // POST: DimInfoMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DimId,DimType,DimSubType,DimCrt,DimPrice,DimImg")] DimInfoMst dimInfoMst)
        {
            if (id != dimInfoMst.DimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dimInfoMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DimInfoMstExists(dimInfoMst.DimId))
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
            return View(dimInfoMst);
        }

        // GET: DimInfoMsts/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimInfoMst = await _context.DimInfoMst
                .FirstOrDefaultAsync(m => m.DimId == id);
            if (dimInfoMst == null)
            {
                return NotFound();
            }

            return View(dimInfoMst);
        }

        // POST: DimInfoMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var dimInfoMst = await _context.DimInfoMst.FindAsync(id);
            _context.DimInfoMst.Remove(dimInfoMst);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DimInfoMstExists(string id)
        {
            return _context.DimInfoMst.Any(e => e.DimId == id);
        }
    }
}
