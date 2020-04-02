using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Platform_Services_Portal.Services;

namespace Platform_Services_Portal.Components
{
    public class LeftMenu : ViewComponent
    {
        public JsonFileServices JsonService;

        public IViewComponentResult Invoke()
        {
            JsonService = new JsonFileServices();
            return View(JsonService.GetLeftMenu());
        }
    }
}
