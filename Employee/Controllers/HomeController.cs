using Employee.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository repository;
        public HomeController(IEmployeeRepository repo)
        {
            repository = repo;
        }
        public int PageSize = 6; //kích cỡ trang
        public ViewResult Index(int productPage = 1) => View(repository.Employees //hiển thị trang 1
                    .OrderBy(p => p.Id)//sắp xếp theo
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize));
    }
}
