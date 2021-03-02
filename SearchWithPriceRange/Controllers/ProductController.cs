﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchWithPriceRange.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        [Route("index")]
        [Route("~/")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}