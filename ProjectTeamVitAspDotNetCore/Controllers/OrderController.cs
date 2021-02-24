using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectTeamVitAspDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTeamVitAspDotNetCore.Controllers
{
    public class OrderController : Controller
    {

        private JwelleryContext db = new JwelleryContext();
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<IActionResult> Index(string searchString)
        {

            List<Order> orders = db.Order.ToList();

            if (!String.IsNullOrEmpty(searchString))
            {
                orders = db.Order.Where(s => s.Id.Contains(searchString) || s.Email.Contains(searchString) || s.Name.Contains(searchString) || s.Phone.Contains(searchString)).ToList();
            }


            List<Product> productsInUser = new List<Product>();

            foreach (Order order in orders)
            {
                var orderId = order.Id;

                List<OrderDetail> orderdetails = db.OrderDetail.Where(x => x.OdId == orderId).ToList();

                List<Product> products = new List<Product>();
                foreach (OrderDetail orderDetail in orderdetails.ToList())
                {
                    var productId = orderDetail.PdId;
                    products.AddRange(db.Product.Where(x => x.PdId == productId).ToList());
                }
                productsInUser.AddRange(products);

            }
            ViewBag.products = productsInUser;


            return View(orders);
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<IActionResult> Details(string id)
        {
            List<Product> productsInUser = new List<Product>();

            List<OrderDetail> orderDetails = new List<OrderDetail>();
            List<OrderDetail> orderdetails = db.OrderDetail.Where(x => x.OdId == id).ToList();
            List<Product> products = db.Product.Where(x => x.PdId == id).ToList();
            decimal? Sum = 0;
            foreach (OrderDetail orderDetail in orderdetails)
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

            Order order = db.Order.FirstOrDefault(m => m.Id == id);

            if (order == null)
            {
                return NotFound();
            }

            @ViewBag.status = order.Status;
            return View(order);
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,CreateTime,Status,Email,,Address,Birthday,Phone,ZipCode,Gender")] Order order)
        {
            if (order.Status == false || order.Status == null )
            {
                order.Status = true;
            }
            else
            {
                order.Status = false;
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
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }
        private bool OrderExits(string id)
        {
            return db.Order.Any(e => e.Id == id);
        }

    }


}

