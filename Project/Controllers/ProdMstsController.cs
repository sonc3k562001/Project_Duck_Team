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
    public class ProdMstsController : Controller
    {
        private readonly DuckTeamProjectContext _context;

        public ProdMstsController(DuckTeamProjectContext context)
        {
            _context = context;
        }

        // GET: ProdMsts
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProdMst.ToListAsync());
        }

        // GET: ProdMsts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prodMst = await _context.ProdMst
                .FirstOrDefaultAsync(m => m.ProdId == id);
            if (prodMst == null)
            {
                return NotFound();
            }

            return View(prodMst);
        }

        // GET: ProdMsts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProdMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProdId,ProdType")] ProdMst prodMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prodMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(prodMst);
        }

        // GET: ProdMsts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prodMst = await _context.ProdMst.FindAsync(id);
            if (prodMst == null)
            {
                return NotFound();
            }
            return View(prodMst);
        }

        // POST: ProdMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ProdId,ProdType")] ProdMst prodMst)
        {
            if (id != prodMst.ProdId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prodMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdMstExists(prodMst.ProdId))
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
            return View(prodMst);
        }

        // GET: ProdMsts/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prodMst = await _context.ProdMst
                .FirstOrDefaultAsync(m => m.ProdId == id);
            if (prodMst == null)
            {
                return NotFound();
            }

            return View(prodMst);
        }

        // POST: ProdMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var prodMst = await _context.ProdMst.FindAsync(id);
            _context.ProdMst.Remove(prodMst);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdMstExists(string id)
        {
            return _context.ProdMst.Any(e => e.ProdId == id);
        }
    }
}
