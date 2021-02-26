using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using ProjectTeamVitAspDotNetCore.Helpers;
using ProjectTeamVitAspDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProjectTeamVitAspDotNetCore.Controllers
{
    public class AccountController : Controller
    {


        private JwelleryContext db = new JwelleryContext();
        private readonly IConfiguration configuration;
        private readonly IWebHostEnvironment webHostEnvironment;
       
        public AccountController(IConfiguration _configuration, IWebHostEnvironment _webHostEnvironment)
        {
            configuration = _configuration;
            webHostEnvironment = _webHostEnvironment;
            
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
        public async Task<IActionResult> Register(User user , IFormFile Avatar)
        {
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            user.ConfirmPassword = BCrypt.Net.BCrypt.HashPassword(user.ConfirmPassword);
            Role Role = db.Role.FirstOrDefault(x=>x.StringRole == "Customer");
            var fileName = Path.GetFileName(Avatar.FileName);
                user.Avatar = fileName;
            user.IdRole = Role.Id;
            db.User.Add(user);
            await db.SaveChangesAsync();
            if (Avatar != null)
            {
                var filepath = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images")).Root + $@"\{fileName}";

                using (FileStream fs = System.IO.File.Create(filepath))
                {
                    Avatar.CopyTo(fs);
                    fs.Flush();
                }
            }
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

            var User = db.User.FirstOrDefault(x => x.Email == email);

            if (account == null)
            {
                ViewBag.error = "Invalid";
                return View("Login");
            }
            else
            {   
                var Role = db.Role.FirstOrDefault(x => x.Id == account.IdRole);

                identity = new ClaimsIdentity(new[]
                {
                    
                    new Claim(ClaimTypes.Name,User.Email),   
                    new Claim(ClaimTypes.Role,Role.StringRole)
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                if (Role.StringRole == "Admin" || Role.StringRole == "SuperAdmin")
                {                   
                    isAuthenticates = true;
                    if (isAuthenticates)
                    {  
                        var principal = new ClaimsPrincipal(identity);
                        var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        return RedirectToAction("Index", "Dashboard", User);
                    }
                }
                if (Role.StringRole == "Customer")
                {
                    isAuthenticate = true;
                    if (isAuthenticate)
                    {
                        var principal = new ClaimsPrincipal(identity);
                        var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        return RedirectToAction("Index", "Product",User);
                    }
                }
                
                return View("Welcome");
            }
            
        }
        

        public IActionResult Signout()
        {
            HttpContext.Session.Clear();
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
            int numberRD = 25;
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
            return View("PasswordReset");
            
        }
        public IActionResult SentEmail(string email)
        {
            var body = "Welcome, please let us know what your problem is so we can assist you in resolving it.";
            var mailHelper = new MailHelper(configuration);
            if (mailHelper.Forgot(configuration["Gmail:Username"], email, body))
            {
                ViewBag.msg = "Please check password in email!";
            }
            else
            {
                ViewBag.msg = "Failed";
            }
            return RedirectToAction("Index","Product");
        }
        public IActionResult Profile()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                ViewBag.cart = cart;
                ViewBag.Count = cart.Count;
            }

            var email = User.FindFirstValue(ClaimTypes.Name);

            User user = db.User.FirstOrDefault(x => x.Email == email);
            ViewBag.User = user;
            return View();
        }
        public async Task<IActionResult> ChangedInformation()
        {
            var email = User.FindFirstValue(ClaimTypes.Name);
            if (email == null)
            {
                return NotFound();
            }

            var user = await db.User.FindAsync(email);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangedInformation(string Email,string Fname,string Lname,string Address, string Bdate,string ZipCode,string Phone,string Gender,IFormFile Avatar)
        {
            Email = User.FindFirstValue(ClaimTypes.Name);
            var user = db.User.FirstOrDefault(x => x.Email == Email);

            
            user.Fname = Fname;
            user.Lname = Lname;
            user.Bdate = Bdate;
            user.Address = Address;
            user.Phone = Phone;
            user.Gender = Gender;
            user.ZipCode = ZipCode;
            if(Avatar != null)
            {
                var avatar = Path.GetFileName(Avatar.FileName);
                user.Avatar = avatar;
            }
            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(user);
                    await db.SaveChangesAsync();
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
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!userExists(user.Email))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Profile));
            }
            return View(user);
        }
        private bool userExists(string email)
        {
            return db.User.Any(e => e.Email == email);
        }

        public IActionResult PasswordChange()
        {  
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PasswordChange(string currentpassword,string newpassword, string confirmnewpassword)
        {
            var email = User.FindFirstValue(ClaimTypes.Name);
            if (currentpassword != newpassword && newpassword == confirmnewpassword)
            {
                var account = checkAccount(email, currentpassword);
                if (account != null)
                {
                    account.Password = BCrypt.Net.BCrypt.HashPassword(newpassword);
                    account.ConfirmPassword = account.Password;

                    db.Update(account);
                    await db.SaveChangesAsync();
                    ViewBag.Mess = "Changed password success!";
                    return Redirect("Profile");
                }
            }
            else
            {
                ViewBag.Error = "Current password and new password are the same or new passwords do not overlap!";
                return View("Profile");
            }
            return  View();
        }

        public async Task<IActionResult> ListOrder(string searchString, string sortOrder)
        {
            var email = User.FindFirstValue(ClaimTypes.Name);

            List<Order> orders = db.Order.Where(x => x.Email == email).ToList();
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            var orderss = from o in db.Order  where(o.Email==email) select o;

            switch (sortOrder)
            {
                case "name_desc":
                    orderss = orderss.OrderByDescending(s => s.Name);
                    break;
                case "Date":
                    orderss = orderss.OrderBy(s => s.Id);
                    break;
                case "date_desc":
                    orderss = orderss.OrderByDescending(s => s.CreateTime);
                    break;
                default:
                    orderss = orderss.OrderBy(s => s.Phone);
                    break;
            }
           
            if (!String.IsNullOrEmpty(searchString))
            {
                orderss = orderss.Where(s => s.Id.Contains(searchString) || s.Name.Contains(searchString) || s.Phone.Contains(searchString)); 
            }
          

            List<Product> productsInUser = new List<Product>();

            foreach (Order order in orders)
            {
                var orderId = order.Id;

                List<OrderDetail> orderdetails = db.OrderDetail.Where(x=>x.OdId == orderId).ToList();
              
                List<Product> products = new List<Product>();
                foreach (OrderDetail orderDetail in orderdetails.ToList())
                {
                    var productId = orderDetail.PdId;
                    products.AddRange(db.Product.Where(x => x.PdId == productId).ToList());
                }
                productsInUser.AddRange(products);
                            
            }
            ViewBag.products = productsInUser;
            

            return View(await orderss.AsNoTracking().ToListAsync());
        }
        public async Task<IActionResult> OrderDetails(string id)
        {

            List<Product> productsInUser = new List<Product>();

            List<OrderDetail> orderDetails = new List<OrderDetail>();
            List<OrderDetail> orderdetails = db.OrderDetail.Where(x => x.OdId == id).ToList();
            List<Product> products = db.Product.Where(x => x.PdId == id).ToList();
            double Sum = 0;
            foreach(OrderDetail orderDetail in orderdetails)
            {
                Product product = db.Product.FirstOrDefault(x => x.PdId == orderDetail.PdId);
                Sum += orderDetail.TotalPrice;
                products.Add(product);

            }


            ViewBag.total = Sum;
            ViewBag.products = products;
            if (id == null)
            {
                return NotFound();
            }

            var Order = await db.Order.FirstOrDefaultAsync(m => m.Id == id);

            if (Order == null)
            {
                return NotFound();
            }

            return View(Order);
        }




        public async Task<IActionResult> EditOrder(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await db.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditOrder(string id, [Bind("Id,Name,CreateTime,Status,Email,,Address,Birthday,Phone,ZipCode,Gender")] Order order)
        {
            
            {

            }
            if (id != order.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(order);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExits(order.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ListOrder));
            }
            return View(order);
        }
        private bool OrderExits(string id)
        {
            return db.Order.Any(e => e.Id == id);
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



    }
}
