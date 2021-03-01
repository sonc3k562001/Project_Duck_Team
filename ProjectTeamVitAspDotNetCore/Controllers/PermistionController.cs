using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using ProjectTeamVitAspDotNetCore.Models;
namespace ProjectTeamVitAspDotNetCore.Controllers
{
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class PermistionController : Controller
    {
        private readonly JwelleryContext _context;
        public PermistionController(JwelleryContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {

            ViewData["PriceSortParm"] = sortOrder == "price" ? "price_desc" : "price";
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
            var users = from s in _context.User select s;

            Role role = _context.Role.FirstOrDefault(x => x.IdRole.Contains(searchString));

            if(!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(x => x.Email.Contains(searchString) || x.Fname.Contains(searchString) ||x.Lname.Contains(searchString) ||x.Address.Contains(searchString)||x.Gender.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "price":
                    users = users.OrderBy(s => s.Bdate);
                    break;
                case "price_desc":
                    users = users.OrderByDescending(s => s.Bdate);
                    break;
                case "name_desc":
                    users = users.OrderByDescending(s => s.Fname).ThenByDescending(users=>users.Lname);
                    break;
                case "name":
                    users = users.OrderBy(s => s.Fname).ThenBy(users=>users.Lname);
                    break;
                default:
                    users = users.OrderBy(s => s.Email);
                    break;
            }

            int pageSize = 10;
            ViewBag.pageSize = pageSize;
            ViewBag.Count = users.Count();
            ViewBag.order = sortOrder;

            return View(await PaginatedList<User>.CreateAsync(users.AsNoTracking(), pageNumber ?? 1, pageSize));
        }
    
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.Email == id);
            ViewBag.user = user;
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

       
        public IActionResult Create()
        {
            ViewData["IdRole"] =new SelectList(_context.Role,"IdRole" ,"IdRole" );
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Fname,Lname,Bdate,Address,Phone,Password,ConfirmPassword,ZipCode,Avatar,Gender,Email,Enable,IdRole")] User user, IFormFile Avatar)
        {
            var value = _context.User.FirstOrDefault(x => x.Email == user.Email);

            if (value != null)
            {
                ViewBag.Error = "Email already exists";
                return View();
            }

            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            user.ConfirmPassword = BCrypt.Net.BCrypt.HashPassword(user.ConfirmPassword);
            user.Avatar = Path.GetFileName(Avatar.FileName);
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            if (Avatar != null)
            {
                var fileName = Path.GetFileName(Avatar.FileName);

                var filepath = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images")).Root + $@"\{fileName}";

                using (FileStream fs = System.IO.File.Create(filepath))
                {
                    Avatar.CopyTo(fs);
                    fs.Flush();
                }
            }
           
            return View(user);
        }

        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FindAsync(id);
            List<Role> roles = _context.Role.ToList();
            if (user == null)
            {
                return NotFound();
            }
            ViewBag.user = user;
            ViewBag.eable = user.Eable;
            ViewBag.roles = roles;
            return View(user);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Fname,Lname,Bdate,Address,Phone,Password,ConfirmPassword,ZipCode,Avatar,Gender,Email,Eable,IdRole")] User user)
        {
            
            if (id != user.Email)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Email))
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
            return View(user);
        }

        
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.Email == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _context.User.FindAsync(id);
            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(string id)
        {
            return _context.User.Any(e => e.Email == id);
        }

    }
}
