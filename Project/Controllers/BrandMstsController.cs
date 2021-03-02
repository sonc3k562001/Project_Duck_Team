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
    public class BrandMstsController : Controller
    {
        private readonly DuckTeamProjectContext _context;

        public BrandMstsController(DuckTeamProjectContext context)
        {
            _context = context;
        }

        // GET: BrandMsts
        public async Task<IActionResult> Index()
        {
            return View(await _context.BrandMst.ToListAsync());
        }

        // GET: BrandMsts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brandMst = await _context.BrandMst
                .FirstOrDefaultAsync(m => m.BrandId == id);
            if (brandMst == null)
            {
                return NotFound();
            }

            return View(brandMst);
        }

        // GET: BrandMsts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BrandMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BrandId,BrandType")] BrandMst brandMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(brandMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(brandMst);
        }

        // GET: BrandMsts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brandMst = await _context.BrandMst.FindAsync(id);
            if (brandMst == null)
            {
                return NotFound();
            }
            return View(brandMst);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("BrandId,BrandType")] BrandMst brandMst)
        {
            if (id != brandMst.BrandId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(brandMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BrandMstExists(brandMst.BrandId))
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
            return View(brandMst);
        }

        // GET: BrandMsts/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brandMst = await _context.BrandMst
                .FirstOrDefaultAsync(m => m.BrandId == id);
            if (brandMst == null)
            {
                return NotFound();
            }

            return View(brandMst);
        }

        // POST: BrandMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var brandMst = await _context.BrandMst.FindAsync(id);
            _context.BrandMst.Remove(brandMst);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BrandMstExists(string id)
        {
            return _context.BrandMst.Any(e => e.BrandId == id);
        }
    }
}
