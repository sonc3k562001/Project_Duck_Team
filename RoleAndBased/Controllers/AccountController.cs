using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using RoleAndBased.Models;
using System.Linq;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace RoleAndBased.Controllers
{
    public class AccountController : Controller
    {
        private mydbContext db = new mydbContext();
        public IActionResult Index()
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
            var User = db.Users;
            user.IdRole = "4";
            User.Add(user);
            await db.SaveChangesAsync();
            return View("Login");
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var account = db.Users.SingleOrDefault(a => a.Email.Equals(email));

            ClaimsIdentity identity = null;
            bool isAuthenticate = false;
            bool isAuthenticates = false;

            if (account == null || string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password) || email != account.Email || password != account.Password)
            {
                ViewBag.error = "Username or password is incorrect !";
                return View("Login");
            }
            if (email == account.Email && password == account.Password)
            {
                var Permission = db.Permissions.FirstOrDefault(x=>x.Id == account.IdRole); 
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name,email),
                    new Claim(ClaimTypes.Role,Permission.PermissionName)
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                if (Permission.PermissionName == "Admin" || Permission.PermissionName == "SuperAdmin")
                {
                    isAuthenticates = true;
                    if (isAuthenticates)
                    {
                        var principal = new ClaimsPrincipal(identity);
                        var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        return RedirectToAction("Index","User");
                    }
                }
                if (Permission.PermissionName == "Customer")
                {
                    isAuthenticate = true;
                    if (isAuthenticate)
                    {
                        var principal = new ClaimsPrincipal(identity);
                        var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View();
        }
       
        public IActionResult Signout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login","Account");
        }
    }
}
