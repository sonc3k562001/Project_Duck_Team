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
    public class GoldKrtMstsController : Controller
    {
        private readonly DuckTeamProjectContext _context;

        public GoldKrtMstsController(DuckTeamProjectContext context)
        {
            _context = context;
        }

        // GET: GoldKrtMsts
        public async Task<IActionResult> Index()
        {
            return View(await _context.GoldKrtMst.ToListAsync());
        }

        // GET: GoldKrtMsts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goldKrtMst = await _context.GoldKrtMst
                .FirstOrDefaultAsync(m => m.GoldTypeId == id);
            if (goldKrtMst == null)
            {
                return NotFound();
            }

            return View(goldKrtMst);
        }

        // GET: GoldKrtMsts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GoldKrtMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GoldTypeId,GoldCrt")] GoldKrtMst goldKrtMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(goldKrtMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(goldKrtMst);
        }

        // GET: GoldKrtMsts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goldKrtMst = await _context.GoldKrtMst.FindAsync(id);
            if (goldKrtMst == null)
            {
                return NotFound();
            }
            return View(goldKrtMst);
        }

        // POST: GoldKrtMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("GoldTypeId,GoldCrt")] GoldKrtMst goldKrtMst)
        {
            if (id != goldKrtMst.GoldTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(goldKrtMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GoldKrtMstExists(goldKrtMst.GoldTypeId))
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
            return View(goldKrtMst);
        }

        // GET: GoldKrtMsts/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goldKrtMst = await _context.GoldKrtMst
                .FirstOrDefaultAsync(m => m.GoldTypeId == id);
            if (goldKrtMst == null)
            {
                return NotFound();
            }

            return View(goldKrtMst);
        }

        // POST: GoldKrtMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var goldKrtMst = await _context.GoldKrtMst.FindAsync(id);
            _context.GoldKrtMst.Remove(goldKrtMst);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GoldKrtMstExists(string id)
        {
            return _context.GoldKrtMst.Any(e => e.GoldTypeId == id);
        }
    }
}
