using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DrinkStores.Models;
using DrinkStores.Models.ViewModels;

namespace DrinkStores.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int PageSize = 3;// số sản phẩm trong một page

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index(string category, int productPage = 1)
             => View(new ProductsListViewModel
             {
                Products = repository.Products
                .Where(p => category == null || p.Category == category)// lọc theo category
                .OrderBy(p => p.ProductID)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
                 PagingInfo = new PagingInfo
                 {
                     CurrentPage = productPage,
                     ItemsPerPage = PageSize,
                     //     TotalItems = repository.Products.Count()
                     TotalItems = category == null ?
                      repository.Products.Count() :
                      repository.Products.Where(
                        e => e.Category == category).Count()
                 },
                 CurrentCategory = category
             });
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
