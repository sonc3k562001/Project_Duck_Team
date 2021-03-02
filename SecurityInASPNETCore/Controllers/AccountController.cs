using Microsoft.AspNetCore.Mvc;
using SecurityInASPNETCore.Models;
using SecurityInASPNETCore.Security;

namespace SecurityInASPNETCore.Controllers
{

    public class AccountController : Controller
    {
        private AccountManager accountManager = new AccountManager();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            AccountModel accountModel = new AccountModel();
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || accountModel.login(username, password) == null)
            {
                ViewBag.error = "Invalid";
                return View("Index");
            }
            else
            {
               
                accountManager.SignIn(this.HttpContext, accountModel.find(username));
                return RedirectToAction("Welcome");
            }
            
        }

        public IActionResult Welcome()
        {
            return View("Welcome");
        }
        public IActionResult AccessDenied()
        {
            return View("AccessDenied");
        }
        public IActionResult Signout()
        {
            accountManager.SignOut(this.HttpContext);
            return RedirectToAction("Index");
        }


    }
}
