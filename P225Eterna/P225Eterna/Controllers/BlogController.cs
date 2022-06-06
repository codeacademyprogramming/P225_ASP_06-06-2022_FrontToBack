using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P225Eterna.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.page = "blog";

            return View();
        }

        public IActionResult Detail(int? id)
        {
            ViewBag.page = "blog";

            return View();
        }
    }
}
