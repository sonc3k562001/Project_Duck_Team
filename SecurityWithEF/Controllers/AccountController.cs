using Microsoft.AspNetCore.Mvc;
using SecurityWithEF.Models;
using SecurityWithEF.Security;
using System.Linq;


namespace SecurityWithEF.Controllers
{
    public class AccountController : Controller
    {
        private MyDBContext db = new MyDBContext();
        private SecurityManager securityManager = new SecurityManager();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            Models.Account account = processLogin(username, password);

            
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)  ||account == null)
            {
                ViewBag.error = "Invalid";
                return View("Index");
            }
            else
            {
                securityManager.SignIn(this.HttpContext, account);
                return RedirectToAction("Welcome");
            }
            
        }

        private Models.Account processLogin(string username,string password)
        {
            var account = db.Accounts.SingleOrDefault(a => a.Username.Equals(username)&& a.Enable == true);
            if(account != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, account.Password))
                {
                    return account;
                }
            }
            return null;
        }
        public IActionResult Welcome()
        {
            return View("Welcome");
        }

        public IActionResult AccessDenied()
        {
            return View("AccessDenied");
        }

        public IActionResult SignOut()
        {
            securityManager.SignOut(this.HttpContext);
            return RedirectToAction("Index");
        }

    }
}
