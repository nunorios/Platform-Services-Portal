using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Platform_Services_Portal.Controllers
{
    [Authorize(Roles = "Member")]
    public class TimeLineController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}