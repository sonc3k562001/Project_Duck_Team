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
    public class StoneMstsController : Controller
    {
        private readonly DuckTeamProjectContext _context;

        public StoneMstsController(DuckTeamProjectContext context)
        {
            _context = context;
        }

        // GET: StoneMsts
        public async Task<IActionResult> Index()
        {
            var duckTeamProjectContext = _context.StoneMst.Include(s => s.StyleCodeNavigation);
            return View(await duckTeamProjectContext.ToListAsync());
        }

        // GET: StoneMsts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stoneMst = await _context.StoneMst
                .Include(s => s.StyleCodeNavigation)
                .FirstOrDefaultAsync(m => m.StyleCode == id);
            if (stoneMst == null)
            {
                return NotFound();
            }

            return View(stoneMst);
        }

        // GET: StoneMsts/Create
        public IActionResult Create()
        {
            ViewData["StyleCode"] = new SelectList(_context.ItemMst, "StyleCode", "StyleCode");
            return View();
        }

        // POST: StoneMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StyleCode,StoneQltyId,StoneGm,StonePcs,StoneCrt,StoneRate,StoneAmt")] StoneMst stoneMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stoneMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StyleCode"] = new SelectList(_context.ItemMst, "StyleCode", "StyleCode", stoneMst.StyleCode);
            return View(stoneMst);
        }

        // GET: StoneMsts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stoneMst = await _context.StoneMst.FindAsync(id);
            if (stoneMst == null)
            {
                return NotFound();
            }
            ViewData["StyleCode"] = new SelectList(_context.ItemMst, "StyleCode", "StyleCode", stoneMst.StyleCode);
            return View(stoneMst);
        }

        // POST: StoneMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StyleCode,StoneQltyId,StoneGm,StonePcs,StoneCrt,StoneRate,StoneAmt")] StoneMst stoneMst)
        {
            if (id != stoneMst.StyleCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stoneMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StoneMstExists(stoneMst.StyleCode))
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
            ViewData["StyleCode"] = new SelectList(_context.ItemMst, "StyleCode", "StyleCode", stoneMst.StyleCode);
            return View(stoneMst);
        }

        // GET: StoneMsts/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stoneMst = await _context.StoneMst
                .Include(s => s.StyleCodeNavigation)
                .FirstOrDefaultAsync(m => m.StyleCode == id);
            if (stoneMst == null)
            {
                return NotFound();
            }

            return View(stoneMst);
        }

        // POST: StoneMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var stoneMst = await _context.StoneMst.FindAsync(id);
            _context.StoneMst.Remove(stoneMst);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StoneMstExists(string id)
        {
            return _context.StoneMst.Any(e => e.StyleCode == id);
        }
    }
}
