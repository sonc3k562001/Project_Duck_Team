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
    public class InquiriesController : Controller
    {
        private readonly DuckTeamProjectContext _context;

        public InquiriesController(DuckTeamProjectContext context)
        {
            _context = context;
        }

        // GET: Inquiries
        public async Task<IActionResult> Index()
        {
            return View(await _context.Inquiry.ToListAsync());
        }

        // GET: Inquiries/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inquiry = await _context.Inquiry
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inquiry == null)
            {
                return NotFound();
            }

            return View(inquiry);
        }

        // GET: Inquiries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Inquiries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,City,Contact,EmailId,Comment,Cdate")] Inquiry inquiry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inquiry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(inquiry);
        }

        // GET: Inquiries/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inquiry = await _context.Inquiry.FindAsync(id);
            if (inquiry == null)
            {
                return NotFound();
            }
            return View(inquiry);
        }

        // POST: Inquiries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,City,Contact,EmailId,Comment,Cdate")] Inquiry inquiry)
        {
            if (id != inquiry.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inquiry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InquiryExists(inquiry.Id))
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
            return View(inquiry);
        }

        // GET: Inquiries/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inquiry = await _context.Inquiry
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inquiry == null)
            {
                return NotFound();
            }

            return View(inquiry);
        }

        // POST: Inquiries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var inquiry = await _context.Inquiry.FindAsync(id);
            _context.Inquiry.Remove(inquiry);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InquiryExists(string id)
        {
            return _context.Inquiry.Any(e => e.Id == id);
        }
    }
}
