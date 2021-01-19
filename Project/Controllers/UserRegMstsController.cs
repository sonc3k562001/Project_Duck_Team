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
    public class UserRegMstsController : Controller
    {
        private readonly DuckTeamProjectContext _context;

        public UserRegMstsController(DuckTeamProjectContext context)
        {
            _context = context;
        }

        // GET: UserRegMsts
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserRegMst.ToListAsync());
        }

        // GET: UserRegMsts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRegMst = await _context.UserRegMst
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (userRegMst == null)
            {
                return NotFound();
            }

            return View(userRegMst);
        }

        // GET: UserRegMsts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserRegMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,UserFname,UserLname,Address,City,State,MobNo,EmailId,Dob,Cdate,Password")] UserRegMst userRegMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userRegMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userRegMst);
        }

        // GET: UserRegMsts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRegMst = await _context.UserRegMst.FindAsync(id);
            if (userRegMst == null)
            {
                return NotFound();
            }
            return View(userRegMst);
        }

        // POST: UserRegMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UserId,UserFname,UserLname,Address,City,State,MobNo,EmailId,Dob,Cdate,Password")] UserRegMst userRegMst)
        {
            if (id != userRegMst.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userRegMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserRegMstExists(userRegMst.UserId))
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
            return View(userRegMst);
        }

        // GET: UserRegMsts/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRegMst = await _context.UserRegMst
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (userRegMst == null)
            {
                return NotFound();
            }

            return View(userRegMst);
        }

        // POST: UserRegMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var userRegMst = await _context.UserRegMst.FindAsync(id);
            _context.UserRegMst.Remove(userRegMst);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserRegMstExists(string id)
        {
            return _context.UserRegMst.Any(e => e.UserId == id);
        }
    }
}
