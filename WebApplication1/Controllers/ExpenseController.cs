using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ExpenseController : Controller
    {
        private Models.AppContext _context;
         
        public ExpenseController()
        {
            _context = new Models.AppContext();
        }

        public IActionResult Index()
        {
            return View();
        }
        public ActionResult ExpenseList()
        {
            var expenses = _context.Expenses.ToList();
            return View(expenses);
        }

        public ActionResult ExpenseInfo()
        {
            return View(new Expense { Id = 0 });
        }


        public  ActionResult SaveExpense(Expense expense)
        {
            if (!ModelState.IsValid)
            {
                return View("ExpenseInfo", expense);
            }
            if(expense.Id == 0)
            {
                _context.Expenses.Add(expense);
            }
            else
            {
                var expenseFromDb = _context.Expenses.FirstOrDefault(e => e.Id == expense.Id);
                if (expenseFromDb == null)
                    return View("Not Found - Son dz");
                expenseFromDb.Title = expense.Title;
                expenseFromDb.PaidBy = expense.PaidBy;
                expenseFromDb.Amount = expense.Amount;
                expenseFromDb.Description = expense.Description;
            }
            _context.SaveChanges();
            return RedirectToAction("ExpenseList");
        }

        public ActionResult Edit(int id)
        {
            if(id == null)
            {
                return View("Not Found - Son Dz");
            }

            var expense = _context.Expenses.FirstOrDefault(e => e.Id == id);
            if(expense == null)
            {
                return View("Not Found - Son Dz");
            }
            return View("ExpenseInfo", expense);
        }

        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return View("Note Found - But Son Dz");
            }

            var expense = _context.Expenses.FirstOrDefault(e => e.Id == id);

            if(expense == null)
            {
                return View("Note Found - But Son Dz");
            }
            _context.Expenses.Remove(expense);
            _context.SaveChanges();
            return RedirectToAction("ExpenseList");

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}
