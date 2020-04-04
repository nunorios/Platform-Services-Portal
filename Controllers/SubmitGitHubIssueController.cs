using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Platform_Services_Portal.Models;
using System.Resources;
using Microsoft.Extensions.Localization;
using Platform_Services_Portal.Services;

namespace Platform_Services_Portal.Controllers
{
    public class SubmitGitHubIssueController : Controller
    {
        public GitHubService gitHubService;
            
        public IActionResult Index()
        {
            return View();
        }

       [HttpPost]
        public async Task<IActionResult> Index(GitHubIssueModel newIssue)
        {
            gitHubService = new GitHubService();
            await gitHubService.SettIssue(newIssue);
            ModelState.Clear();
            newIssue.Title = "";
            newIssue.Body = "";
            return View(newIssue);
        }
    }
}