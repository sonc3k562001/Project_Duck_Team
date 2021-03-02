using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoComplete.Models;

namespace AutoComplete.Controllers
{
    [Route("api/product")]
    public class ProductRestController : Controller
    {
        
        
        private DataContext db = new DataContext();

        [Produces("application/json")]
        [HttpGet("search")]
        public async Task <IActionResult> Search()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                var names = db.Product.Where(x => x.Name.Contains(term)).Select(p=>p.Name).ToList();
                return Ok(names);
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
