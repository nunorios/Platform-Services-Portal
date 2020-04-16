using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Platform_Services_Portal.Models;
using Platform_Services_Portal.Services;
using System.Threading.Tasks;

namespace Platform_Services_Portal.Controllers
{
    [Authorize(Roles = "Member")]
    public class SubmitGitHubIssueController : Controller
    {
        public GitHubService gitHubService;
        IConfiguration Configuration;

        public SubmitGitHubIssueController(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public GitHubIssueModel GitHubIssue { get; set; }

        [Route("/SubmitGitHubIssue/Index/{Provider}")]
        public IActionResult Index(string Provider)
        {
            try
            {
                GitHubIssue = new GitHubIssueModel();
                GitHubIssue.Provider = Configuration.GetSection("GitHubRepo").GetSection(Provider)["RepoName"];
                GitHubIssue.HtmlUrl = "draft";
            }
            catch {
            
            }
            return View(GitHubIssue);
        }

        [HttpPost]
        public async Task<IActionResult> Submit(GitHubIssueModel newIssue)
        {
            gitHubService = new GitHubService(Configuration);
            var result = await gitHubService.SettIssue(newIssue, newIssue.Provider);
            if (result.HtmlUrl != null)
            {
                ModelState.Clear();
                newIssue.Title = "";
                newIssue.Body = "";
                if (newIssue.Labels != null)
                {
                    newIssue.Labels.Clear();
                }
                TempData["Success"] = "Issue created with success";
            }
            else
            {
                ModelState.AddModelError(string.Empty, newIssue.Exception);
            }
            return View(nameof(Index), newIssue);
        }

        [Route("/SubmitGitHubIssue/Edit")]
        public IActionResult Edit()
        {
            GitHubIssue = JsonConvert.DeserializeObject<GitHubIssueModel>(TempData["issue"].ToString());
            GitHubIssue.HtmlUrl = "draft";
            return View(nameof(Index), GitHubIssue);


        }
    }
}