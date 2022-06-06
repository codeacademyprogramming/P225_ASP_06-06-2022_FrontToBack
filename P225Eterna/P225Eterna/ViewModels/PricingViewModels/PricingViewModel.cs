using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P225Eterna.Models;

namespace P225Eterna.ViewModels.PricingViewModels
{
    public class PricingViewModel
    {
        public List<Plan> Plans { get; set; }
        public List<FeatureItem> FeatureItems { get; set; }
    }
}
