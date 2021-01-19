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
    public class ItemMstsController : Controller
    {
        private readonly DuckTeamProjectContext _context;

        public ItemMstsController(DuckTeamProjectContext context)
        {
            _context = context;
        }

        // GET: ItemMsts
        public async Task<IActionResult> Index()
        {
            var duckTeamProjectContext = _context.ItemMst.Include(i => i.Brand).Include(i => i.Cat).Include(i => i.Certify).Include(i => i.GoldType).Include(i => i.Prod);
            return View(await duckTeamProjectContext.ToListAsync());
        }

        // GET: ItemMsts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemMst = await _context.ItemMst
                .Include(i => i.Brand)
                .Include(i => i.Cat)
                .Include(i => i.Certify)
                .Include(i => i.GoldType)
                .Include(i => i.Prod)
                .FirstOrDefaultAsync(m => m.StyleCode == id);
            if (itemMst == null)
            {
                return NotFound();
            }

            return View(itemMst);
        }

        // GET: ItemMsts/Create
        public IActionResult Create()
        {
            ViewData["BrandId"] = new SelectList(_context.BrandMst, "BrandId", "BrandId");
            ViewData["CatId"] = new SelectList(_context.CatMst, "CatId", "CatId");
            ViewData["CertifyId"] = new SelectList(_context.CertifyMst, "CertifyId", "CertifyId");
            ViewData["GoldTypeId"] = new SelectList(_context.GoldKrtMst, "GoldTypeId", "GoldTypeId");
            ViewData["ProdId"] = new SelectList(_context.ProdMst, "ProdId", "ProdId");
            return View();
        }

        // POST: ItemMsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StyleCode,Pairs,BrandId,Quantity,CatId,ProdQuality,CertifyId,ProdId,GoldTypeId,GoldWt,StoneWt,NetGold,WstgPer,Wstg,TotGrossWt,GoldRate,GoldAmt,GoldMaking,StoneMaking,OtherMaking,TotMaking,Mrp")] ItemMst itemMst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itemMst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BrandId"] = new SelectList(_context.BrandMst, "BrandId", "BrandId", itemMst.BrandId);
            ViewData["CatId"] = new SelectList(_context.CatMst, "CatId", "CatId", itemMst.CatId);
            ViewData["CertifyId"] = new SelectList(_context.CertifyMst, "CertifyId", "CertifyId", itemMst.CertifyId);
            ViewData["GoldTypeId"] = new SelectList(_context.GoldKrtMst, "GoldTypeId", "GoldTypeId", itemMst.GoldTypeId);
            ViewData["ProdId"] = new SelectList(_context.ProdMst, "ProdId", "ProdId", itemMst.ProdId);
            return View(itemMst);
        }

        // GET: ItemMsts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemMst = await _context.ItemMst.FindAsync(id);
            if (itemMst == null)
            {
                return NotFound();
            }
            ViewData["BrandId"] = new SelectList(_context.BrandMst, "BrandId", "BrandId", itemMst.BrandId);
            ViewData["CatId"] = new SelectList(_context.CatMst, "CatId", "CatId", itemMst.CatId);
            ViewData["CertifyId"] = new SelectList(_context.CertifyMst, "CertifyId", "CertifyId", itemMst.CertifyId);
            ViewData["GoldTypeId"] = new SelectList(_context.GoldKrtMst, "GoldTypeId", "GoldTypeId", itemMst.GoldTypeId);
            ViewData["ProdId"] = new SelectList(_context.ProdMst, "ProdId", "ProdId", itemMst.ProdId);
            return View(itemMst);
        }

        // POST: ItemMsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StyleCode,Pairs,BrandId,Quantity,CatId,ProdQuality,CertifyId,ProdId,GoldTypeId,GoldWt,StoneWt,NetGold,WstgPer,Wstg,TotGrossWt,GoldRate,GoldAmt,GoldMaking,StoneMaking,OtherMaking,TotMaking,Mrp")] ItemMst itemMst)
        {
            if (id != itemMst.StyleCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemMst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemMstExists(itemMst.StyleCode))
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
            ViewData["BrandId"] = new SelectList(_context.BrandMst, "BrandId", "BrandId", itemMst.BrandId);
            ViewData["CatId"] = new SelectList(_context.CatMst, "CatId", "CatId", itemMst.CatId);
            ViewData["CertifyId"] = new SelectList(_context.CertifyMst, "CertifyId", "CertifyId", itemMst.CertifyId);
            ViewData["GoldTypeId"] = new SelectList(_context.GoldKrtMst, "GoldTypeId", "GoldTypeId", itemMst.GoldTypeId);
            ViewData["ProdId"] = new SelectList(_context.ProdMst, "ProdId", "ProdId", itemMst.ProdId);
            return View(itemMst);
        }

        // GET: ItemMsts/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemMst = await _context.ItemMst
                .Include(i => i.Brand)
                .Include(i => i.Cat)
                .Include(i => i.Certify)
                .Include(i => i.GoldType)
                .Include(i => i.Prod)
                .FirstOrDefaultAsync(m => m.StyleCode == id);
            if (itemMst == null)
            {
                return NotFound();
            }

            return View(itemMst);
        }

        // POST: ItemMsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var itemMst = await _context.ItemMst.FindAsync(id);
            _context.ItemMst.Remove(itemMst);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemMstExists(string id)
        {
            return _context.ItemMst.Any(e => e.StyleCode == id);
        }
    }
}
