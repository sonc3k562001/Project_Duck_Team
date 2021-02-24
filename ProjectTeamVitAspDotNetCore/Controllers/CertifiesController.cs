using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectTeamVitAspDotNetCore.Models;

namespace ProjectTeamVitAspDotNetCore.Controllers
{
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class CertifiesController : Controller
    {
        private readonly JwelleryContext _context;

        public CertifiesController(JwelleryContext context)
        {
            _context = context;
        }

        // GET: Certifies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Certify.ToListAsync());
        }

        // GET: Certifies/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var certify = await _context.Certify
                .FirstOrDefaultAsync(m => m.CertifyId == id);
            if (certify == null)
            {
                return NotFound();
            }

            return View(certify);
        }

        // GET: Certifies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Certifies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CertifyId,CertifyType")] Certify certify)
        {
            if (ModelState.IsValid)
            {
                _context.Add(certify);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(certify);
        }

        // GET: Certifies/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var certify = await _context.Certify.FindAsync(id);
            if (certify == null)
            {
                return NotFound();
            }
            return View(certify);
        }

        // POST: Certifies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CertifyId,CertifyType")] Certify certify)
        {
            if (id != certify.CertifyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(certify);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CertifyExists(certify.CertifyId))
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
            return View(certify);
        }

        // GET: Certifies/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var certify = await _context.Certify
                .FirstOrDefaultAsync(m => m.CertifyId == id);
            if (certify == null)
            {
                return NotFound();
            }

            return View(certify);
        }

        // POST: Certifies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var certify = await _context.Certify.FindAsync(id);
            _context.Certify.Remove(certify);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CertifyExists(string id)
        {
            return _context.Certify.Any(e => e.CertifyId == id);
        }
    }
}
