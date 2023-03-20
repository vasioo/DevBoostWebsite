using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DevBoost.Controllers
{
    public class PricingController : Controller
    {
        private readonly ILogger<PricingController> _logger;

        public PricingController(ILogger<PricingController> logger)
        {
            _logger = logger;
        }

        public string Item { get; set; }

        [Authorize]
        [HttpGet]
        public IActionResult Purchasing()
        {
            return View();
        }
    }
}
