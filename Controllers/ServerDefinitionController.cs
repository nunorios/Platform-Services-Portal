using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Platform_Services_Portal.Models;
using Platform_Services_Portal.Services;

namespace Platform_Services_Portal.Controllers
{
    public class ServerDefinitionController : Controller
    {
        public JsonFileServices ServerService;
        public IEnumerable<ServerDefinition> ServerDefinition { get; private set; }

        public IEnumerable<Server> Server { get; private set; }
        public IActionResult Index()
        {
            ServerService = new JsonFileServices();
            //Server = ServerService.GetServer("Server100");
            ServerDefinition = ServerService.GetServers();
            return View(ServerDefinition);
        }

        [HttpPost]
        public IActionResult Index(string servername)
        {
            ServerService = new JsonFileServices();
            ServerDefinition = ServerService.GetServers(servername);
            return View(ServerDefinition);
        }
    }
}