using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Platform_Services_Portal.Controllers
{
    public class TimeLineController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}