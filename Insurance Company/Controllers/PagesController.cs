﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Insurance_Company.Controllers
{
    public class PagesController : Controller
    {
        
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult FAQ()
        {
            return View();
        }
    }
}