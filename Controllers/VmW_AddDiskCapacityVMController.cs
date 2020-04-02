using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Platform_Services_Portal.Services;
using Platform_Services_Portal.Models;

namespace Platform_Services_Portal.Controllers
{
    public class VmW_AddDiskCapacityVMController : Controller
    {
        public GitHubService gitHubService;
        // GET: VmW_AddDiskCapacityVM
        public ActionResult Index()
        {
            return View();
        }

        // GET: VmW_AddDiskCapacityVM/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VmW_AddDiskCapacityVM/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: VmW_AddDiskCapacityVM/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            //collection.Keys.Add. HttpContext.Session.GetString("Customer", customer);

            try
            {
                //gitHubService.SettIssue(newIssue);
                //ModelState.Clear();
                //newIssue.Title = "";
                //newIssue.Body = "";
                //return View(newIssue);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VmW_AddDiskCapacityVM/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VmW_AddDiskCapacityVM/Edit/5
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

        // GET: VmW_AddDiskCapacityVM/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VmW_AddDiskCapacityVM/Delete/5
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