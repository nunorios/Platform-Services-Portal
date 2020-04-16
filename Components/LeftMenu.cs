using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Platform_Services_Portal.Models;
using Platform_Services_Portal.Services;
using System.Collections.Generic;

namespace Platform_Services_Portal.Components
{
    public class LeftMenu : ViewComponent
    {
        public JsonFileServices JsonService;

        public IEnumerable<LeftMenuModel> OpcoesMenu { get; set; }

        public LeftMenuModel leftMenu { get; set; }
        //public IViewComponentResult Invoke()
        //{
        //    JsonService = new JsonFileServices();
        //    OpcoesMenu = JsonService.GetLeftMenu();
        //    foreach (var item in OpcoesMenu)
        //    {
        //        leftMenu = item;
        //    }
        //    setMenuToSession(leftMenu);
        //    return View(OpcoesMenu);
        //}


        public IViewComponentResult Invoke()
        {
            JsonService = new JsonFileServices();
            return View(JsonService.GetLeftMenu());
        }

        public void setMenuToSession(LeftMenuModel letMenu)
        {
            var _letMenu = JsonConvert.SerializeObject(letMenu);
            HttpContext.Session.SetString("LeftMenu", _letMenu);
        }
    }
}
