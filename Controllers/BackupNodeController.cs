using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Platform_Services_Portal.Models;
using Platform_Services_Portal.Services;
using System.Threading.Tasks;

namespace Platform_Services_Portal.Controllers
{
    [Authorize(Roles = "Member")]
    public class BackupNodeController : Controller
    {
        IConfiguration Configuration;
        string Provider = "BaaS";

        public BackupNodeController(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }
        public JsonFileServices JsonService;
        public Server Server { get; set; }


        public IActionResult Index()
        {
            JsonService = new JsonFileServices();

            return View(JsonService.GetServerList(HttpContext.Session.GetString("Customer"), "CurrentConfig"));
        }

        [Route("/BackupNode/Index/{userAction},{serverName}")]
        public async Task<IActionResult> Create(string userAction, string serverName)
        {
            JsonService = new JsonFileServices();
            foreach (var s in JsonService.GetServer(HttpContext.Session.GetString("Customer"), "CurrentConfig", serverName))
            {
                Server = s;
                setServerToSession(Server);
            }
            JsonService = new JsonFileServices();
            if (userAction == "NewNode")
            {
                Server = getServerFromSession();
                GitHubIssueModel issue = new GitHubIssueModel();
                issue.Title = Server.Customer + " - Create new backup node for server " + Server.ServerName;
                string _Body = "Create new backup node for server " + Server.ServerName;
                _Body += "\n\nCustomer: " + Server.Customer;
                _Body += "\nOperating System: " + Server.OperatingSystem;
                _Body += "\nEnvironment: " + Server.Environment;
                _Body += "\nChange record:";
                issue.Body = _Body;
                issue.Provider = Provider;
                issue.Label = "enhancement;";
                GitHubService gitHubService = new GitHubService(Configuration);
                issue = await gitHubService.SettIssue(issue, Provider);
                if (issue.HtmlUrl != null)
                {
                    ModelState.Clear();
                    TempData["Success"] = "Service request for server "+Server.ServerName +" created with success.Request id: " + issue.IssueID + " . Link para o issue: " + issue.HtmlUrl;
                }
                else
                {
                    ModelState.Clear();
                    TempData["Error"] = "Error while creating the request " +  issue.Exception;
                }
                return RedirectToAction(nameof(Index));
            }
            if (userAction == "BlockNode")
            {
                Server = getServerFromSession();
                GitHubIssueModel issue = new GitHubIssueModel();
                issue.Title = Server.Customer + " - Lock backup node for server " + Server.ServerName;
                string _Body = "Lock backup node for server " + Server.ServerName;
                _Body += "\n\nCustomer: " + Server.Customer;
                _Body += "\nOperating System: " + Server.OperatingSystem;
                _Body += "\nEnvironment: " + Server.Environment;
                _Body += "\nChange record:";
                issue.Body = _Body;
                issue.Provider = Provider;
                issue.Label = "enhancement;";
                setIssueToSession(issue);
                TempData["issue"] = JsonConvert.SerializeObject(issue);
                return RedirectToAction("Edit", "SubmitGitHubIssue");
            }
            if (userAction == "StandByNode")
            {
                Server = getServerFromSession();
                GitHubIssueModel issue = new GitHubIssueModel();
                issue.Title = Server.Customer + " - Standby node for server " + Server.ServerName;
                string _Body = "Standby node for server " + Server.ServerName;
                _Body += "\n\nCustomer: " + Server.Customer;
                _Body += "\nOperating System: " + Server.OperatingSystem;
                _Body += "\nEnvironment: " + Server.Environment;
                _Body += "\nChange record:";
                issue.Body = _Body;
                issue.Provider = Provider;
                issue.Label = "enhancement;";
                setIssueToSession(issue);
                TempData["issue"] = JsonConvert.SerializeObject(issue);
                return RedirectToAction("Edit", "SubmitGitHubIssue");
            }
            if (userAction == "Activate")
            {
                Server = getServerFromSession();
                GitHubIssueModel issue = new GitHubIssueModel();
                issue.Title = Server.Customer + " - Activate backup node for server " + Server.ServerName;
                string _Body = "Activate backup node for server " + Server.ServerName;
                _Body += "\n\nCustomer: " + Server.Customer;
                _Body += "\nOperating System: " + Server.OperatingSystem;
                _Body += "\nEnvironment: " + Server.Environment;
                _Body += "\nChange record:";
                issue.Body = _Body;
                issue.Provider = Provider;
                issue.Label = "enhancement;";
                setIssueToSession(issue);
                TempData["issue"] = JsonConvert.SerializeObject(issue);
                return RedirectToAction("Edit", "SubmitGitHubIssue");
            }
            if (userAction == "RobotInventory")
            {
                Server = getServerFromSession();
                GitHubIssueModel issue = new GitHubIssueModel();
                issue.Title = Server.Customer + " - Get Robot inventory for RobotSN: ";
                string _Body = "Get Robot inventory for RobotSN: <write the Robot serial number>";
                _Body += "\n\nCustomer: " + Server.Customer;
                issue.Body = _Body;
                issue.Provider = Provider;
                issue.Label = "enhancement;";
                setIssueToSession(issue);
                TempData["issue"] = JsonConvert.SerializeObject(issue);
                return RedirectToAction("Edit", "SubmitGitHubIssue");
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }

        }
        public IActionResult RobotInventory()
        {
            string Customer = HttpContext.Session.GetString("Customer");
            GitHubIssueModel issue = new GitHubIssueModel();
            issue.Title = Customer + " - Get Robot inventory for RobotSN: ";
            string _Body = "Get Robot inventory for RobotSN: <write the Robot serial number>";
            _Body += "\n\nCustomer: " + Customer;
            issue.Body = _Body;
            issue.Provider = Provider;
            issue.Label = "enhancement;";
            setIssueToSession(issue);
            TempData["issue"] = JsonConvert.SerializeObject(issue);
            return RedirectToAction("Edit", "SubmitGitHubIssue");
        }

        public async Task<IActionResult> Submit(BackupNodeModel BCKNode)
        {

            GitHubIssueModel issue = new GitHubIssueModel();

            GitHubService gitHubService = new GitHubService(Configuration);
            await gitHubService.SettIssue(issue,  "BaaS");
            return RedirectToAction(nameof(Index));

        }
        public Server getServerFromSession()
        {
            var str = HttpContext.Session.GetString("Server");
            Server = JsonConvert.DeserializeObject<Server>(str);
            return Server;
        }
       
        public void setServerToSession(Server server)
        {
            var serverToSession = JsonConvert.SerializeObject(server);
            HttpContext.Session.SetString("Server", serverToSession);
        }
        public void setIssueToSession(GitHubIssueModel issue)
        {
            var issueToSession = JsonConvert.SerializeObject(issue);
            HttpContext.Session.SetString("ServiceRequest", issueToSession);
        }
    }
}