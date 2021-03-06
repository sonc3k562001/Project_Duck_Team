﻿using System;
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
    [Authorize(Roles = "Admin,SuperAdmin,Employee")]
    public class ColorsController : Controller
    {
        
        private readonly JwelleryContext _context;

        public ColorsController(JwelleryContext context)
        {
            _context = context;
        }

        // GET: Colors
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewData["NameSortParm"] = sortOrder == "name" ? "name_desc" : "name";

            ViewData["CurrentFilter"] = searchString;


            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;
            var colors = from s in _context.Color select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                colors = colors.Where(s => s.Name.Contains(searchString) || s.ColorId.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    colors = colors.OrderByDescending(s => s.Name);
                    break;
                case "name":
                    colors = colors.OrderBy(s => s.Name);
                    break;
                default:
                    colors = colors.OrderBy(s => s.ColorId);
                    break;
            }

            int pageSize = 10;
            ViewBag.pageSize = pageSize;
            ViewBag.Count = colors.Count();
            ViewBag.order = sortOrder;
            return View(await PaginatedList<Color>.CreateAsync(colors.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: Colors/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var color = await _context.Color
                .FirstOrDefaultAsync(m => m.ColorId == id);
            if (color == null)
            {
                return NotFound();
            }

            return View(color);
        }

        // GET: Colors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Colors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ColorId,Name")] Color color)
        {
            var value = _context.Color.FirstOrDefault(x => x.ColorId == color.ColorId);
            if(value != null)
            {
                ViewBag.error = "Color code already exists";
                return View();
            }


            if (ModelState.IsValid)
            {
                _context.Add(color);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(color);
        }

        // GET: Colors/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var color = await _context.Color.FindAsync(id);
            if (color == null)
            {
                return NotFound();
            }
            return View(color);
        }

        // POST: Colors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ColorId,Name")] Color color)
        {
            if (id != color.ColorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(color);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ColorExists(color.ColorId))
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
            return View(color);
        }

        // GET: Colors/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var color = await _context.Color
                .FirstOrDefaultAsync(m => m.ColorId == id);
            if (color == null)
            {
                return NotFound();
            }

            return View(color);
        }

        // POST: Colors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var color = await _context.Color.FindAsync(id);
            _context.Color.Remove(color);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ColorExists(string id)
        {
            return _context.Color.Any(e => e.ColorId == id);
        }
    }
}
