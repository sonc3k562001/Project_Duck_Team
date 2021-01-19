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
    public class AdminLoginMstsController : Controller
    {
        private readonly DuckTeamProjectContext _context;

        public AdminLoginMstsController(DuckTeamProjectContext context)
        {
            _context = context;
        }

        // GET: AdminLoginMsts
        public async Task<IActionResult> Index()
        {
            return View(await _context.AdminLoginMst.ToListAsync());
        }

        // GET: AdminLoginMsts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminLoginMst = await _context.AdminLoginMst
                .FirstOrDefaultAsync(m => m.UserName == id);
            if (adminLoginMst == null)
            {
                return NotFound();
            }

            return View(adminLoginMst);
        }

        // GET: AdminLoginMsts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdminLoginMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserName,Password")] AdminLoginMst adminLoginMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adminLoginMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adminLoginMst);
        }

        // GET: AdminLoginMsts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminLoginMst = await _context.AdminLoginMst.FindAsync(id);
            if (adminLoginMst == null)
            {
                return NotFound();
            }
            return View(adminLoginMst);
        }

        // POST: AdminLoginMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UserName,Password")] AdminLoginMst adminLoginMst)
        {
            if (id != adminLoginMst.UserName)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adminLoginMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminLoginMstExists(adminLoginMst.UserName))
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
            return View(adminLoginMst);
        }

        // GET: AdminLoginMsts/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminLoginMst = await _context.AdminLoginMst
                .FirstOrDefaultAsync(m => m.UserName == id);
            if (adminLoginMst == null)
            {
                return NotFound();
            }

            return View(adminLoginMst);
        }

        // POST: AdminLoginMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var adminLoginMst = await _context.AdminLoginMst.FindAsync(id);
            _context.AdminLoginMst.Remove(adminLoginMst);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminLoginMstExists(string id)
        {
            return _context.AdminLoginMst.Any(e => e.UserName == id);
        }
    }
}
