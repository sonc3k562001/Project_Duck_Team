using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProjectTeamVitAspDotNetCore.Helpers;
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
        private readonly IConfiguration configuration;
        private JwelleryContext db = new JwelleryContext();
        public OrderController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewData["PriceSortParm"] = sortOrder == "price" ? "price_desc" : "price";
            ViewData["NameSortParm"] = sortOrder == "name" ? "name_desc" : "name";
            ViewData["CurrentFilter"] = searchString;

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;


            
            var orders = from s in db.Order select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                orders = orders.Where(s => s.Id.Contains(searchString) || s.Email.Contains(searchString) || s.Name.Contains(searchString) || s.Phone.Contains(searchString));
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
            switch (sortOrder)
            {
                case "price":
                    orders = orders.OrderBy(s => s.CreateTime);
                    break;
                case "price_desc":
                    orders = orders.OrderByDescending(s => s.CreateTime);
                    break;
                case "name_desc":
                    orders = orders.OrderByDescending(s => s.Name);
                    break;
                case "name":
                    orders = orders.OrderBy(s => s.Name);
                    break;
                default:
                    orders = orders.OrderBy(s => s.Id);
                    break;
            }

            int pageSize = 10;
            ViewBag.pageSize = pageSize;
            ViewBag.Count = orders.Count();
            ViewBag.order = sortOrder;


            return View(await PaginatedList<Order>.CreateAsync(orders.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<IActionResult> Details(string id)
        {
            List<Product> productsInUser = new List<Product>();

            List<OrderDetail> orderDetails = new List<OrderDetail>();
            List<OrderDetail> orderdetails = db.OrderDetail.Where(x => x.OdId == id).ToList();
            List<Product> products = db.Product.Where(x => x.PdId == id).ToList();
            double Sum = 0;
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
            var account = db.User.FirstOrDefault(x => x.Email == order.Email);
            if (order.Status == true)
            {

                var body = "Dear " + account.Fname + " " + account.Lname + "!<br/>Thank you for using our service and have a nice day!";
                var mailHelper = new MailHelper(configuration);
                if (mailHelper.Forgot(configuration["Gmail:Username"], account.Email, body))
                {
                    ViewBag.msg = "Sent Mail Successfully! Please check password in email";
                }
                else
                {
                    ViewBag.msg = "Failed";
                }
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

