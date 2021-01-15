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
    public class CartListsController : Controller
    {
        private readonly DuckTeamProjectContext _context;

        public CartListsController(DuckTeamProjectContext context)
        {
            _context = context;
        }

        // GET: CartLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.CartList.ToListAsync());
        }

        // GET: CartLists/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartList = await _context.CartList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cartList == null)
            {
                return NotFound();
            }

            return View(cartList);
        }

        // GET: CartLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CartLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductName,Mrp")] CartList cartList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cartList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cartList);
        }

        // GET: CartLists/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartList = await _context.CartList.FindAsync(id);
            if (cartList == null)
            {
                return NotFound();
            }
            return View(cartList);
        }

        // POST: CartLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,ProductName,Mrp")] CartList cartList)
        {
            if (id != cartList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cartList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartListExists(cartList.Id))
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
            return View(cartList);
        }

        // GET: CartLists/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartList = await _context.CartList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cartList == null)
            {
                return NotFound();
            }

            return View(cartList);
        }

        // POST: CartLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var cartList = await _context.CartList.FindAsync(id);
            _context.CartList.Remove(cartList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartListExists(string id)
        {
            return _context.CartList.Any(e => e.Id == id);
        }
    }
}
