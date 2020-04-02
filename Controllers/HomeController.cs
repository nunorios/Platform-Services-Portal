using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Platform_Services_Portal.Models;
using Microsoft.AspNetCore.Http;

namespace Platform_Services_Portal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (Request.Query.ContainsKey("customer"))
            {
                string customer = Request.QueryString.Value.Replace("?customer=", "").ToString();
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
