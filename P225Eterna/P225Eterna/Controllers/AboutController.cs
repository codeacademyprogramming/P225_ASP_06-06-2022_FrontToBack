﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P225Eterna.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.page = "about";

            return View();
        }
    }
}
