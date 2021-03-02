using FiltersInDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltersInDotNetCore.Controllers
{
    [Route("api/product")]
    public class ProductsRestController : Controller
    {
        private ProductContext db = new ProductContext();

        [Produces("application/json")]
        [HttpGet("search")]
        public async Task<IActionResult> Search()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                var names = db.Products.Where(x => x.Name.Contains(term)).Select(p => p.Name).ToList();
                return Ok(names);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
