using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectTeamVitAspDotNetCore.Models;

namespace ProjectTeamVitAspDotNetCore.Controllers
{
    public class StonesController : Controller
    {
        private readonly JwelleryContext _context;

        public StonesController(JwelleryContext context)
        {
            _context = context;
        }

        // GET: Stones
        public async Task<IActionResult> Index()
        {
            return View(await _context.Stone.ToListAsync());
        }

        // GET: Stones/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stone = await _context.Stone
                .FirstOrDefaultAsync(m => m.StoneId == id);
            if (stone == null)
            {
                return NotFound();
            }

            return View(stone);
        }

        // GET: Stones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Stones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StoneId,Name,Description,Price,StoneGm,StoneCrt,StoneRate,StoneAmt")] Stone stone)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stone);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stone);
        }

        // GET: Stones/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stone = await _context.Stone.FindAsync(id);
            if (stone == null)
            {
                return NotFound();
            }
            return View(stone);
        }

        // POST: Stones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StoneId,Name,Description,Price,StoneGm,StoneCrt,StoneRate,StoneAmt")] Stone stone)
        {
            if (id != stone.StoneId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stone);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StoneExists(stone.StoneId))
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
            return View(stone);
        }

        // GET: Stones/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stone = await _context.Stone
                .FirstOrDefaultAsync(m => m.StoneId == id);
            if (stone == null)
            {
                return NotFound();
            }

            return View(stone);
        }

        // POST: Stones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var stone = await _context.Stone.FindAsync(id);
            _context.Stone.Remove(stone);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StoneExists(string id)
        {
            return _context.Stone.Any(e => e.StoneId == id);
        }
    }
}
