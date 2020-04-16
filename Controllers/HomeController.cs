using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Platform_Services_Portal.Models;
using System;
using System.Diagnostics;

namespace Platform_Services_Portal.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private PortalMetricsContext _context;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger, PortalMetricsContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("User  '{UserId}' logged in.", User.Identity.Name);
            if (Request.Query.ContainsKey("customer"))
            {
                string customer = Request.QueryString.Value.Replace("?customer=", "").ToString();
                _logger.LogDebug(DateTime.UtcNow + "| selected customer " + customer);
                HttpContext.Session.SetString("Customer", customer);
                //TempData["customer"] = Request.QueryString.Value.Replace("?customer=", "").ToString();
            }
            return View();
        }
        [HttpPost]
        [Route("Home/{customer}")]
        public IActionResult Index(string customer)
        {
           
            string strName = Convert.ToString(customer);
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult About()
        {
            ViewBag.Message = HttpContext.Session.GetString("Customer");

            return View();
        }
    }
}
