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
    public class JewelTypeMstsController : Controller
    {
        private readonly DuckTeamProjectContext _context;

        public JewelTypeMstsController(DuckTeamProjectContext context)
        {
            _context = context;
        }

        // GET: JewelTypeMsts
        public async Task<IActionResult> Index()
        {
            return View(await _context.JewelTypeMst.ToListAsync());
        }

        // GET: JewelTypeMsts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jewelTypeMst = await _context.JewelTypeMst
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jewelTypeMst == null)
            {
                return NotFound();
            }

            return View(jewelTypeMst);
        }

        // GET: JewelTypeMsts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JewelTypeMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,JewelleryType")] JewelTypeMst jewelTypeMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jewelTypeMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jewelTypeMst);
        }

        // GET: JewelTypeMsts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jewelTypeMst = await _context.JewelTypeMst.FindAsync(id);
            if (jewelTypeMst == null)
            {
                return NotFound();
            }
            return View(jewelTypeMst);
        }

        // POST: JewelTypeMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,JewelleryType")] JewelTypeMst jewelTypeMst)
        {
            if (id != jewelTypeMst.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jewelTypeMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JewelTypeMstExists(jewelTypeMst.Id))
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
            return View(jewelTypeMst);
        }

        // GET: JewelTypeMsts/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jewelTypeMst = await _context.JewelTypeMst
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jewelTypeMst == null)
            {
                return NotFound();
            }

            return View(jewelTypeMst);
        }

        // POST: JewelTypeMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var jewelTypeMst = await _context.JewelTypeMst.FindAsync(id);
            _context.JewelTypeMst.Remove(jewelTypeMst);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JewelTypeMstExists(string id)
        {
            return _context.JewelTypeMst.Any(e => e.Id == id);
        }
    }
}
