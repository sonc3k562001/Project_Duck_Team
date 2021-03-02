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
    public class CatMstsController : Controller
    {
        private readonly DuckTeamProjectContext _context;

        public CatMstsController(DuckTeamProjectContext context)
        {
            _context = context;
        }

        // GET: CatMsts
        public async Task<IActionResult> Index()
        {
            return View(await _context.CatMst.ToListAsync());
        }

        // GET: CatMsts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catMst = await _context.CatMst
                .FirstOrDefaultAsync(m => m.CatId == id);
            if (catMst == null)
            {
                return NotFound();
            }

            return View(catMst);
        }

        // GET: CatMsts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CatMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CatId,CatName")] CatMst catMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(catMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(catMst);
        }

        // GET: CatMsts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catMst = await _context.CatMst.FindAsync(id);
            if (catMst == null)
            {
                return NotFound();
            }
            return View(catMst);
        }

        // POST: CatMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CatId,CatName")] CatMst catMst)
        {
            if (id != catMst.CatId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(catMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CatMstExists(catMst.CatId))
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
            return View(catMst);
        }

        // GET: CatMsts/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catMst = await _context.CatMst
                .FirstOrDefaultAsync(m => m.CatId == id);
            if (catMst == null)
            {
                return NotFound();
            }

            return View(catMst);
        }

        // POST: CatMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var catMst = await _context.CatMst.FindAsync(id);
            _context.CatMst.Remove(catMst);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CatMstExists(string id)
        {
            return _context.CatMst.Any(e => e.CatId == id);
        }
    }
}
