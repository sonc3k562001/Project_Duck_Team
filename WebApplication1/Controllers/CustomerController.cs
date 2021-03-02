using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        private Models.AppContext _context;

        public CustomerController()
        {
            _context = new Models.AppContext();
        }

        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult CustomerList()
        {
            var customer = _context.Customers.ToList();
            return View(customer);
        }


        [HttpGet]
        public async Task<ActionResult> CustomerList(string searchString)
        {
            ViewData["GetCustomerdeltails"] = searchString;
            var customers = from m in _context.Customers select m;
          
            if (!String.IsNullOrEmpty(searchString))
            {
                customers = customers.Where(s => s.CustomerName.Contains(searchString));
            }
            return View(await customers.AsNoTracking().ToListAsync());
        }

        public ActionResult CustomerInfo()
        {
            return View(new Customer { Id = 0 });
        }


        public ActionResult SaveCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return View("CustomerInfo", customer);
            }
            if (customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var customerFromDb = _context.Customers.FirstOrDefault(e => e.Id == customer.Id);
                if (customerFromDb == null)
                    return View("Not Found - Son dz");
                customerFromDb.CustomerName = customer.CustomerName;
                customerFromDb.Birthday = customer.Birthday;
                customerFromDb.Address = customer.Address;
                customerFromDb.Phone = customer.Phone;
                customerFromDb.Email = customer.Email;

            }
            _context.SaveChanges();
            return RedirectToAction("CustomerList");
        }

        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return View("Not Found - Son Dz");
            }

            var customer = _context.Customers.FirstOrDefault(e => e.Id == id);
            if (customer == null)
            {
                return View("Not Found - Son Dz");
            }
            return View("CustomerInfo", customer);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return View("Note Found - But Son Dz");
            }

            var customer = _context.Customers.FirstOrDefault(e => e.Id == id);

            if (customer == null)
            {
                return View("Note Found - But Son Dz");
            }
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return RedirectToAction("CustomerList");

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}
