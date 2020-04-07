using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Platform_Services_Portal.Models;
using Platform_Services_Portal.Services;
using ObjectsComparer;


namespace Platform_Services_Portal.Controllers
{
    public class ServerController : Controller
    {
        public JsonFileServices JsonService;

        public Server originalServer;
        public Server server { get; set; }

        IEnumerable<Difference> differences;


        public ActionResult Index()
        {
            JsonService = new JsonFileServices();
            //return View(JsonService.GetServerList());
            return View(JsonService.GetServerList(HttpContext.Session.GetString("Customer"), "CurrentConfig"));
        }
        // GET: Server
        [Route("/Server/Index/{userAction}")]
        public ActionResult Index(string userAction)
        {
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
            JsonService = new JsonFileServices();
            //return View(JsonService.GetServerList());
            return View(JsonService.GetServerList(HttpContext.Session.GetString("Customer"), "CurrentConfig"));
        }

        // GET: called by Index to display details for server
        [Route("/Server/Details/{ServerName}")]
        public ActionResult Details(string serverName)
        {
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
            if (_server.ServerName is null)
            {
                server = getServerFromSession();
                return View(server);
            }
            else
            {
                if (!compareServerConfig(_server))
                {
                    setServerToSession(_server);
                }
                return Redirect(nameof(Details));
            }
        }
        [Route("/Server/Edit/Add_Disk")]
        public ActionResult Add_Disk()
        {
            server = getServerFromSession();
            Disk _newDisk = new Disk();
            _newDisk.DiskLabel = "new disk label";
            server.Disks.Add(_newDisk);
            setServerToSession(server);
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