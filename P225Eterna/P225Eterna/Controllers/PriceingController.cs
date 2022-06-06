using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P225Eterna.DAL;
using P225Eterna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P225Eterna.ViewModels.PricingViewModels;

namespace P225Eterna.Controllers
{
    public class PriceingController : Controller
    {
        private readonly AppDbContext _context;

        public PriceingController(AppDbContext context)
        {
            ViewBag.page = "pricing";

            _context = context;
        }

        public IActionResult Index()
        {
            List<Plan> plans = _context.Plans.Include(p=>p.PlanFeatures).ToList();
            List<FeatureItem> featureItems = _context.FeatureItems.ToList();

            PricingViewModel pricingViewModel = new PricingViewModel
            {
                Plans = plans,
                FeatureItems = featureItems
            };

            return View(pricingViewModel);
        }
    }
}
