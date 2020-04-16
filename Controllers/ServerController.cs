using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ObjectsComparer;
using Platform_Services_Portal.Models;
using Platform_Services_Portal.Services;
using System.Collections.Generic;

namespace Platform_Services_Portal.Controllers
{
    [Authorize(Roles = "Member")]
    public class ServerController : Controller
    {
        private readonly ILogger<ServerController> _logger;
        public JsonFileServices JsonService;
        public Server originalServer;
        public Server server { get; set; }

        IEnumerable<Difference> differences;

        public ServerController(ILogger<ServerController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            _logger.LogInformation("User '{UserId}' navigated to Server Configuration", User.Identity.Name);
            JsonService = new JsonFileServices();
            //return View(JsonService.GetServerList());
            return View(JsonService.GetServerList(HttpContext.Session.GetString("Customer"), "CurrentConfig"));
        }
        // GET: Server
        [Route("/Server/Index/{userAction}")]
        public ActionResult Index(string userAction)
        {
            _logger.LogInformation("User '{UserId}' navigated to Server Configuration and choose '{userAction}'", User.Identity.Name, userAction);
            if (userAction == "Commit")
            {
                return View(JsonService.GetServerList(HttpContext.Session.GetString("Customer"), "CurrentConfig"));
            }
            if (userAction == "Discard")
            {
                JsonService = new JsonFileServices();
                foreach (var s in JsonService.GetServer(HttpContext.Session.GetString("Customer"), "CurrentConfig", getServerFromSession().ServerName))
                {
                    originalServer = s;
                }
                setServerToSession(originalServer);
                return RedirectToAction(nameof(Details));
            }
            else
            {
                return View(JsonService.GetServerList(HttpContext.Session.GetString("Customer"), "CurrentConfig"));
            }
        }

        public ActionResult Commit()
        {
            _logger.LogInformation("User '{UserId}' navigated to Server Configuration and commited changes to DSC '{userAction}'", User.Identity.Name);
            JsonService = new JsonFileServices();
            //return View(JsonService.GetServerList());
            return View(JsonService.GetServerList(HttpContext.Session.GetString("Customer"), "CurrentConfig"));
        }

        // GET: called by Index to display details for server
        [Route("/Server/Details/{ServerName}")]
        public ActionResult Details(string serverName)
        {
            _logger.LogInformation("User '{UserId}' navigated to Server Configuration and choose Details for server '{server}'", User.Identity.Name, serverName);
            JsonService = new JsonFileServices();
            foreach (var s in JsonService.GetServer(HttpContext.Session.GetString("Customer"), "CurrentConfig", serverName))
            {
                server = s;
                setServerToSession(server);
            }
            return View(server);
        }

        public ActionResult Details()
        {
            try
            {
                ViewBag.Differences = getDifferencesFromSession();
            }
            catch (System.Exception ex)
            { }

            server = getServerFromSession();
            return View(server);
        }

        [Route("/Server/Edit")]
        public ActionResult Edit(Server _server)
        {
            _logger.LogInformation("User '{UserId}' navigated to Server Configuration and choose Edit");
            if (_server.ServerName is null)
            {
                server = getServerFromSession();
                _logger.LogInformation("User '{UserId}' navigated to Server Configuration and choose Edit server '{server}' with the current DSC '{dsc}'", User.Identity.Name, server.ServerName, server.ToString());
                return View(server);
            }
            else
            {
                if (!compareServerConfig(_server))
                {
                    _logger.LogInformation("User '{UserId}' navigated to Server Configuration and choose Edit server '{server}' with the new DSC '{dsc}'", User.Identity.Name, _server.ServerName, _server.ToString());
                    setServerToSession(_server);
                }
                return Redirect(nameof(Details));
            }
        }
        [Route("/Server/Edit/Add_Disk")]
        public ActionResult Add_Disk()
        {
            
            server = getServerFromSession();
            _logger.LogInformation("User '{UserId}' navigated to Server Configuration and choose Add disk to server '{server}' with the current DSC '{dsc}'", User.Identity.Name, server.ServerName, server.ToString());
            Disk _newDisk = new Disk();
            _newDisk.DiskLabel = "new disk label";
            server.Disks.Add(_newDisk);
            setServerToSession(server);
            _logger.LogInformation("User '{UserId}' navigated to Server Configuration and choose Add disk to server '{server}' with the new DSC '{dsc}'", User.Identity.Name, server.ServerName, server.ToString());
            return RedirectToAction(nameof(Edit));
        }


        public ActionResult Export(Server _server)
        {
            if (_server.ServerName is null)
            {
                server = getServerFromSession();
                return Content(server.ToString(), "application/Json");
            }
            else
            {
                if (!compareServerConfig(_server))
                {
                    setServerToSession(_server);
                }
                _logger.LogInformation("User '{UserId}' navigated to Server Configuration and choose to export configuration of server '{server}' with the current DSC '{dsc}'", User.Identity.Name, _server.ServerName, server.ToString());
                return Content(_server.ToString(), "application/Json");
            }

        }


        public bool compareServerConfig(Server toCompare)
        {
            JsonService = new JsonFileServices();
            foreach (var s in JsonService.GetServer(HttpContext.Session.GetString("Customer"), "CurrentConfig", toCompare.ServerName))
            {
                originalServer = s;
            }
            var comparer = new ObjectsComparer.Comparer<Server>();
            var isEqual = comparer.Compare(originalServer, toCompare, out differences);
            setDifferencesToSession(differences);
            return isEqual;
        }
        public void setServerToSession(Server server)
        {
            var serverToSession = JsonConvert.SerializeObject(server);
            HttpContext.Session.SetString("Server", serverToSession);
        }

        public void setDifferencesToSession(IEnumerable<Difference> _differences)
        {
            var _differencesToSession = JsonConvert.SerializeObject(_differences);
            HttpContext.Session.SetString("differences", _differencesToSession);
        }
        public IEnumerable<Difference> getDifferencesFromSession()
        {
            var str = HttpContext.Session.GetString("differences");
            differences = JsonConvert.DeserializeObject<IEnumerable<Difference>>(str);
            return differences;
        }
        public Server getServerFromSession()
        {
            var str = HttpContext.Session.GetString("Server");
            server = JsonConvert.DeserializeObject<Server>(str);
            return server;
        }


    }
}