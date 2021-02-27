using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectTeamVitAspDotNetCore.Helpers;
using ProjectTeamVitAspDotNetCore.Models;
using ProjectTeamVitAspDotNetCore.PayPalHeper;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;

namespace ProjectTeamVitAspDotNetCore.Controllers
{
    [Route("cart")]
    public class CartController : Controller
    {
        private JwelleryContext db = new JwelleryContext();
        private IConfiguration configuration { get; }

        public CartController(IConfiguration _configuration)
        {
            configuration = _configuration;

        }

        [Route("index")]
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if(cart != null)
            {
                ViewBag.cart = cart;
                ViewBag.Count = cart.Count;
                ViewBag.total = cart.Sum(i => i.Product.Price * i.Quantity);
                return View("Index");
            }
            else
            {
                return View("CartNull");
            }
        }


        [Route("buy/{id}")]
        public IActionResult Buy(string id,string size)
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                var cart = new List<Item>();
                cart.Add(new Item() { Product = db.Product.Find(id), Quantity = 1,Size = size});
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = Exists(cart, id);
                if (index == -1)
                {
                    cart.Add(new Item() { Product = db.Product.Find(id), Quantity = 1 ,Size = size});
                }
                else
                {
                    cart[index].Quantity++;
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }


        [Route("remove/{id}")]
        public IActionResult Remove(string id)
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = Exists(cart, id);
            if (index == -1)
            {
                return View("CartNull");
            }
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return Redirect("Index");
        }

        private int Exists(List<Item> cart, string id)
        {
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.PdId == id)
                {
                    return i;
                }
            }
            return -1;
        }

      
        public IActionResult Checkout()
        {
            var email = User.FindFirstValue(ClaimTypes.Name);
            var user  = db.User.FirstOrDefault(x => x.Email == email);
            if (email == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(i => i.Product.Price * i.Quantity);
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout(Double total,User user)
        {

            var carts = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.total = total;

            Order order = new Order();
            
            order.CreateTime = DateTime.Now;
            order.Id ="OD"+DateTime.Now.Year * 10000 + DateTime.Now.Month * 100 + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second;
            order.Name = user.Fname +" " + user.Lname;
            order.Birthday = user.Bdate;
            order.Email = user.Email;
            order.Gender = user.Gender;
            order.Phone = user.Phone;
            order.Address = user.Address;
            order.Status = false;
            order.ZipCode = user.ZipCode;
            order.Email = User.FindFirstValue(ClaimTypes.Name); ;

            db.Add(order);

            foreach (Item i in carts)
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.OdId = order.Id;
                orderDetail.PdId = i.Product.PdId;
                orderDetail.Quantity = i.Quantity;
                orderDetail.TotalPrice = i.Quantity * i.Product.Price;
                orderDetail.Size = i.Size;
                db.Add(orderDetail);
                db.SaveChanges();
            }
            HttpContext.Session.Clear();
            await db.SaveChangesAsync();
            return View("Thanks");
        }

        
        [Route("CheckoutPaypal")]
        [HttpPost]
        public async Task<IActionResult> CheckoutPaypal(double total)
        {
            var email = User.FindFirstValue(ClaimTypes.Name);
            if(email == null)
            {
                return RedirectToAction("Login", "Account");
            }
            User user = db.User.FirstOrDefault(x => x.Email == email);

            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(i => i.Product.Price * i.Quantity);
            var payPalAPI = new PayPalAPI(configuration);
            string url = await payPalAPI.getRedirectURLToPayPal(total, "USD");
            return Redirect(url);
        }

        [Route("success")]
        public async Task<IActionResult> Success([FromQuery(Name = "paymentId")] string paymentId, [FromQuery(Name = "payerID")] string payerID)
        {
            var email = User.FindFirstValue(ClaimTypes.Name);
            User user = db.User.FirstOrDefault(x => x.Email == email);
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");

            var payPalAPI = new PayPalAPI(configuration);
            PayPalPaymentExecutedResponse result = await payPalAPI.executedPayment(paymentId, payerID);

            Order order = new Order();
        

            order.Name = result.payer.payer_info.first_name+" " + result.payer.payer_info.last_name;
            order.Address = result.payer.payer_info.shipping_address.line1+","+ result.payer.payer_info.shipping_address.line2 +","+ result.payer.payer_info.shipping_address.city +","+ result.payer.payer_info.shipping_address.state+"," + result.payer.payer_info.shipping_address.country_code ;
            order.ZipCode = result.payer.payer_info.country_code;
            order.Id = result.cart;
            order.CreateTime = result.create_time;
            order.Phone = user.Phone;
            order.Status = false ;
            order.Email = email;
            db.Add(order);
            foreach (Item i in cart)
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.OdId = order.Id;
                orderDetail.PdId = i.Product.PdId;
                orderDetail.Quantity = i.Quantity;
                orderDetail.TotalPrice = i.Quantity * i.Product.Price;
                orderDetail.Size = i.Size;
                db.Add(orderDetail);
                db.SaveChanges();
            }
            HttpContext.Session.Clear();
            await db.SaveChangesAsync();

            return View("Thanks");
        }
    }

}
