﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P225Eterna.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.page = "home";

            return View();
        }
    }
}