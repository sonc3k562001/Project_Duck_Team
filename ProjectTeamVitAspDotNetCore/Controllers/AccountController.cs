using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectTeamVitAspDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProjectTeamVitAspDotNetCore.Controllers
{
    public class AccountController : Controller
    {
        private JwelleryContext db = new JwelleryContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome()
        {
            return View();
        }
        public IActionResult PasswordChange()
        {
            return View();
        }
        public IActionResult PasswordReset()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(User user)
        {
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            user.IdRole = "4";
            db.Users.Add(user);
            await db.SaveChangesAsync();
            return View("Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string email, string password)
        {
            var account = checkAccount(email, password);
            ClaimsIdentity identity = null;
            bool isAuthenticate = false;
            bool isAuthenticates = false;

            var FullName = db.Users.FirstOrDefault(x => x.Email == email);

            if (account == null)
            {
                ViewBag.error = "Invalid";
                return View("Login");
            }
            else
            {

                HttpContext.Session.SetString("name", FullName.Fname);
                var Role = db.Roles.FirstOrDefault(x => x.Id == account.IdRole);
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name,email),
                    new Claim(ClaimTypes.Role,Role.StringRole)
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                if (Role.StringRole == "Admin" || Role.StringRole == "SuperAdmin")
                {
                    
                    isAuthenticates = true;
                    if (isAuthenticates)
                    {
                        
                        var principal = new ClaimsPrincipal(identity);
                        var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        return RedirectToAction("Welcome", "Account");
                    }
                }
                if (Role.StringRole == "Customer")
                {
                    isAuthenticate = true;
                    if (isAuthenticate)
                    {
                     
                        var principal = new ClaimsPrincipal(identity);
                        var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        return RedirectToAction("Welcome", "Account");
                    }
                }
                
                return View("Welcome");
            }
            
        }

        private User checkAccount(string email, string password)
        {
            var account = db.Users.SingleOrDefault(a => a.Email.Equals(email));


            if (account != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, account.Password))
                {
                    return account;
                }
            }
            return null;
        }

        public IActionResult Signout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}
