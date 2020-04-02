using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Platform_Services_Portal.Models;
using Platform_Services_Portal.Services;

namespace Platform_Services_Portal.Controllers
{
    public class ServerController : Controller
    {
        public JsonFileServices JsonService;
        public Server server { get; set; }
        public Disk disk { get; set; }

        public void setServerToSession(Server server)
        {
            var serverToSession = JsonConvert.SerializeObject(server);
            HttpContext.Session.SetString("Server", serverToSession);
        }
        public Server getServerFromSession()
        {
            var str = HttpContext.Session.GetString("Server");
            server = JsonConvert.DeserializeObject<Server>(str);
            return server;
        }
        // GET: Server
        public ActionResult Index()
        {
            JsonService = new JsonFileServices();
            return View(JsonService.GetServerList());
        }

        // GET: Server/Details/5
        [Route("/Server/Details/{ServerName}")]
        public ActionResult Details(string serverName)
        {
            JsonService = new JsonFileServices();
            foreach (var s in JsonService.GetServer(serverName))
            {
                server = s;
                setServerToSession(server);
            }
            return View(server);
        }
        public ActionResult Details()
        {
            server = getServerFromSession();
            return View(server);
        }

        // GET: Server/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Server/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Server/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        [Route("/Server/Edit/{ServerName}")]
        public ActionResult Edit(string serverName)
        {
            //var str = HttpContext.Session.GetString("Server");
            //server = JsonConvert.DeserializeObject<Server>(str);
            return View(getServerFromSession());
        }
        [Route("/Server/EditDisk/{DiskLabel}")]
        public ActionResult EditDisk(string diskLabel)
        {
            server = getServerFromSession();
            Disk disk = new Disk();
            foreach (var d in server.Disks)
            {
                if (d.DiskLabel == diskLabel)
                {
                    disk = d;
                }
            }
            return View(disk);
        }

        //[Route("/Server/ChangeDisk/{diskLabel}")]
        public ActionResult ChangeDisk(Disk editDisk)
        {
            server = getServerFromSession();
            IEnumerable<Disk> disksList = server.Disks;
            foreach (var d in disksList)
            {
                if (d.DiskLabel == editDisk.DiskLabel)
                {
                    d.DiskSize = editDisk.DiskSize;
                }
            }
            server.Disks = disksList;
            setServerToSession(server);
            HttpContext.Session.Remove("Disk");
            return RedirectToAction(nameof(Details));
        }

        // POST: Server/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Server/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Server/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}