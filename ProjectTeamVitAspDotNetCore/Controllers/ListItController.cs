﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjectTeamVitAspDotNetCore.Controllers
{
    public class ListItController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}