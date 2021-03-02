using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RoleAndBased.Helpers;
using RoleAndBased.Models;


namespace RoleAndBased.Controllers
{
    [Route("cart")]
    public class CartController : Controller
    {
        private readonly mydbContext db = new mydbContext();

        [Route("index")]
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session,"cart");
            ViewBag.cart = cart;
            ViewBag.Count = cart.Count;

            ViewBag.total = cart.Sum(i => i.Product.Price * i.Quantity);
            return View();
        }


        [Route("buy/{id}")]
        public IActionResult Buy(int id)
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                var cart = new List<Item>();
                cart.Add(new Item() { Product = db.Products.Find(id), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = Exists(cart, id);
                if (index == -1)
                {
                    cart.Add(new Item() { Product = db.Products.Find(id), Quantity = 1 });
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
        public IActionResult Remove(int id)
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = Exists(cart, id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }

        private int Exists(List<Item> cart, int id)
        {
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id == id)
                {
                    return i;
                }
            }
            return -1;
        }


        public IActionResult Checkout(string id)
        {
            var UserId = db.Users.Where(x => x.Id == id);
            if (UserId == null)
            {
                return View();
            }
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(i => i.Product.Price * i.Quantity);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout(List<Item> cart)
        {
            var carts = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            var orderDetail = db.OrderDetails;
            var listItem = carts.ToList();
            for (int i = 0; i < listItem.Count; i++)
            {
                var idP = listItem[i].Product.Id;
                int qty = listItem[i].Quantity;
                var totalP = listItem[i].Product.Price * qty;
                int id = DateTime.Now.Year * 10000 + DateTime.Now.Month * 100 + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + i;

                var orderDetails = new OrderDetail();
                orderDetails.Id = id;
                orderDetails.IdProduct = idP;
                orderDetails.Quantity = qty;
                orderDetails.TotalPrice = totalP;
                orderDetail.Add(orderDetails);
            }
            await db.SaveChangesAsync();
            return View("Thanks");
        }
    }

}
