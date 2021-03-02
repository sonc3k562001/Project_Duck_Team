using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PasswordStrength.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PasswordStrength.Controllers
{

    public class AccountController : Controller
    {
        private DataContext db = new DataContext();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View("Login");
        }


        public IActionResult SignUp()
        {
            return View("SignUp");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(Account account)
        {
            account.Password = BCrypt.Net.BCrypt.HashPassword(account.Password);
            db.Account.Add(account);
            await db.SaveChangesAsync();
            return View("Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string username, string password)
        {
            var account = checkAccount(username, password);
            var FullName = db.Account.FirstOrDefault(x => x.Username == username);
            if (account == null)
            {
                 ViewBag.error = "Invalid";
                return View("Login");
            }
            else
            {
                HttpContext.Session.SetString("username", FullName.FullName);
                return View("Welcome");
            }

        }
        private Account checkAccount(string username, string password)
        {
            var account = db.Account.SingleOrDefault(a => a.Username.Equals(username));


            if (account != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, account.Password))
                {
                    return account;
                }
            }
            return null;
        }

    }
}
