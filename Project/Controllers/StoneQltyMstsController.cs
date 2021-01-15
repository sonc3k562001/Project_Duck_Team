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
    public class StoneQltyMstsController : Controller
    {
        private readonly DuckTeamProjectContext _context;

        public StoneQltyMstsController(DuckTeamProjectContext context)
        {
            _context = context;
        }

        // GET: StoneQltyMsts
        public async Task<IActionResult> Index()
        {
            return View(await _context.StoneQltyMst.ToListAsync());
        }

        // GET: StoneQltyMsts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stoneQltyMst = await _context.StoneQltyMst
                .FirstOrDefaultAsync(m => m.StoneQltyId == id);
            if (stoneQltyMst == null)
            {
                return NotFound();
            }

            return View(stoneQltyMst);
        }

        // GET: StoneQltyMsts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StoneQltyMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StoneQltyId,StoneQlty")] StoneQltyMst stoneQltyMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stoneQltyMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stoneQltyMst);
        }

        // GET: StoneQltyMsts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stoneQltyMst = await _context.StoneQltyMst.FindAsync(id);
            if (stoneQltyMst == null)
            {
                return NotFound();
            }
            return View(stoneQltyMst);
        }

        // POST: StoneQltyMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StoneQltyId,StoneQlty")] StoneQltyMst stoneQltyMst)
        {
            if (id != stoneQltyMst.StoneQltyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stoneQltyMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StoneQltyMstExists(stoneQltyMst.StoneQltyId))
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
            return View(stoneQltyMst);
        }

        // GET: StoneQltyMsts/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stoneQltyMst = await _context.StoneQltyMst
                .FirstOrDefaultAsync(m => m.StoneQltyId == id);
            if (stoneQltyMst == null)
            {
                return NotFound();
            }

            return View(stoneQltyMst);
        }

        // POST: StoneQltyMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var stoneQltyMst = await _context.StoneQltyMst.FindAsync(id);
            _context.StoneQltyMst.Remove(stoneQltyMst);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StoneQltyMstExists(string id)
        {
            return _context.StoneQltyMst.Any(e => e.StoneQltyId == id);
        }
    }
}
