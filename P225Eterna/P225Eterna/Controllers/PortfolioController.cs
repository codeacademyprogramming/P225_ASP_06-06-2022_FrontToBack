using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P225Eterna.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.page = "portfolio";

            return View();
        }

        public IActionResult Detail(int? id)
        {
            ViewBag.page = "portfolio";

            return View();
        }
    }
}
