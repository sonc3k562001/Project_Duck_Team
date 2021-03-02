using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoogleChart.Models;

namespace GoogleChart.Controllers
{

    [Route("api/product")]
    public class ProductRestController : Controller
    {

        [HttpGet("findall")]
        public List<Product> findAll()
        {
            var data = new ProductContext().Products.ToList();
            return data;
        }

    }
}
