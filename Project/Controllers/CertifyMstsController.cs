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
    public class CertifyMstsController : Controller
    {
        private readonly DuckTeamProjectContext _context;

        public CertifyMstsController(DuckTeamProjectContext context)
        {
            _context = context;
        }

        // GET: CertifyMsts
        public async Task<IActionResult> Index()
        {
            return View(await _context.CertifyMst.ToListAsync());
        }

        // GET: CertifyMsts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var certifyMst = await _context.CertifyMst
                .FirstOrDefaultAsync(m => m.CertifyId == id);
            if (certifyMst == null)
            {
                return NotFound();
            }

            return View(certifyMst);
        }

        // GET: CertifyMsts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CertifyMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CertifyId,CertifyType")] CertifyMst certifyMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(certifyMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(certifyMst);
        }

        // GET: CertifyMsts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var certifyMst = await _context.CertifyMst.FindAsync(id);
            if (certifyMst == null)
            {
                return NotFound();
            }
            return View(certifyMst);
        }

        // POST: CertifyMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CertifyId,CertifyType")] CertifyMst certifyMst)
        {
            if (id != certifyMst.CertifyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(certifyMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CertifyMstExists(certifyMst.CertifyId))
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
            return View(certifyMst);
        }

        // GET: CertifyMsts/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var certifyMst = await _context.CertifyMst
                .FirstOrDefaultAsync(m => m.CertifyId == id);
            if (certifyMst == null)
            {
                return NotFound();
            }

            return View(certifyMst);
        }

        // POST: CertifyMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var certifyMst = await _context.CertifyMst.FindAsync(id);
            _context.CertifyMst.Remove(certifyMst);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CertifyMstExists(string id)
        {
            return _context.CertifyMst.Any(e => e.CertifyId == id);
        }
    }
}
