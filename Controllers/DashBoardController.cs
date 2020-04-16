using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Platform_Services_Portal.Controllers
{
    [Authorize(Roles = "Member")]
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            string Costumer = HttpContext.Session.GetString("Customer");
            ViewBag.Costumer = Costumer;
            return View();
        }

        public IActionResult NBVMware()
        {
            string Costumer = HttpContext.Session.GetString("Customer");
            ViewBag.Costumer = Costumer;
            return View();
        }

      
    }
}