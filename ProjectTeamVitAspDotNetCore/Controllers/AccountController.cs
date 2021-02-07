using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProjectTeamVitAspDotNetCore.Helpers;
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
        private readonly IConfiguration configuration;
        private readonly IWebHostEnvironment webHostEnvironment;

        public AccountController(IConfiguration _configuration, IWebHostEnvironment _webHostEnvironment)
        {
            configuration = _configuration;
            webHostEnvironment = _webHostEnvironment;
        }
        private readonly JwelleryContext db;
        public AccountController(JwelleryContext _db)
        {
            db = _db;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome()
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
            db.User.Add(user);
            await db.SaveChangesAsync();
            return View("Login");
        }


        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string email, string password)
        {
            var account = checkAccount(email, password);
            ClaimsIdentity identity = null;
            bool isAuthenticate = false;
            bool isAuthenticates = false;

            var FullName = db.User.FirstOrDefault(x => x.Email == email);

            if (account == null)
            {
                ViewBag.error = "Invalid";
                return View("Login");
            }
            else
            {

                HttpContext.Session.SetString("name", FullName.Fname);
                var Role = db.Role.FirstOrDefault(x => x.Id == account.IdRole);
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
            var account = db.User.SingleOrDefault(a => a.Email.Equals(email));


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


        public IActionResult PasswordReset()
        {
            return View("PasswordReset");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PasswordReset(string email)
        {
            int numberRD = 50;
            string randomStr = "";
            try
            {

                int[] myIntArray = new int[numberRD];
                int x;  
                Random autoRand = new Random();
                for (x = 0; x < numberRD; x++)
                {
                    myIntArray[x] = System.Convert.ToInt32(autoRand.Next(0, 9));
                    randomStr += (myIntArray[x].ToString());
                }
            }
            catch
            {
                randomStr = "error";
            }

            var account = db.User.FirstOrDefault(x => x.Email == email);

            account.Password = BCrypt.Net.BCrypt.HashPassword(randomStr);
            account.ConfirmPassword = account.Password;

            db.Update(account);
            await db.SaveChangesAsync();

            var body = "Dear " + account.Fname + " " + account.Lname + "!<br/> Your current password is: " +randomStr+ "<br/> Wish you a good day!";
            var mailHelper = new MailHelper(configuration);
            if (mailHelper.Forgot(configuration["Gmail:Username"], account.Email, body))
            {
                ViewBag.msg = "Sent Mail Successfully! Please check password in email";
            }
            else
            {
                ViewBag.msg = "Failed";
            }
            return View("PasswordReset",account.Email);
            
        }

      
        public IActionResult PasswordChange()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PasswordChange(string Email,string Password)
        {
            var account = db.User.FirstOrDefault(x => x.Email == Email);
            account.Password = BCrypt.Net.BCrypt.HashPassword(Password);
            account.ConfirmPassword = account.Password;

            db.Update(account);
            await db.SaveChangesAsync();

            return View("PasswordChange");
        }

    }
}
