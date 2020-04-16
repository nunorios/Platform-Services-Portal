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
    public class MonitoringController : Controller
    {
        IConfiguration Configuration;
        string Provider = "HST";

        public MonitoringController(IConfiguration configuration)
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

        [Route("/Monitoring/Index/{userAction},{serverName}")]
        public async Task<IActionResult> ITM(string userAction, string serverName)
        {
            JsonService = new JsonFileServices();
            foreach (var s in JsonService.GetServer(HttpContext.Session.GetString("Customer"), "CurrentConfig", serverName))
            {
                Server = s;
                setServerToSession(Server);
            }
            JsonService = new JsonFileServices();
            Server = getServerFromSession();
            GitHubIssueModel issue = new GitHubIssueModel();
            GitHubService gitHubService = new GitHubService(Configuration);
            if (userAction == "SOAgentInstall")
            {
                issue.Title = Server.Customer + " - Install new ITM agent for server " + Server.ServerName;
                string _Body = "Install new ITM agent for server " + Server.ServerName;
                _Body += "\n\nCustomer: " + Server.Customer;
                _Body += "\nOperating System: " + Server.OperatingSystem;
                _Body += "\nEnvironment: " + Server.Environment;
                _Body += "\nInstallation path (if diferent from standard): ";
                _Body += "\nChange record:";
                issue.Body = _Body;
                issue.Provider = Provider;
                issue.Label = "enhancement;";
                setIssueToSession(issue);
                TempData["issue"] = JsonConvert.SerializeObject(issue);
                return RedirectToAction("Edit", "SubmitGitHubIssue");
            }
            if (userAction == "SubsysAgentInstall")
            {
                issue.Title = Server.Customer + " - Install new ITM subsystem agent for server " + Server.ServerName;
                string _Body = "Install new ITM subsystem agent for server " + Server.ServerName;
                _Body += "\n\nCustomer: " + Server.Customer;
                _Body += "\nOperating System: " + Server.OperatingSystem;
                _Body += "\nEnvironment: " + Server.Environment;
                _Body += "\nSubsystem name: ";
                _Body += "\nSubsystem version: ";
                _Body += "\nInstallation path (if diferent from standard): ";
                _Body += "\nService account: ";
                _Body += "\nChange record:";
                issue.Body = _Body;
                issue.Provider = Provider;
                issue.Label = "enhancement;";
                setIssueToSession(issue);
                TempData["issue"] = JsonConvert.SerializeObject(issue);
                return RedirectToAction("Edit", "SubmitGitHubIssue");
            }
            if (userAction == "NewSituation")
            {
                issue.Title = Server.Customer + " - Create new situation for server " + Server.ServerName;
                string _Body = "Create new situation for server " + Server.ServerName;
                _Body += "\n\nCustomer: " + Server.Customer;
                _Body += "\nOperating System: " + Server.OperatingSystem;
                _Body += "\nEnvironment: " + Server.Environment;
                _Body += "\nSituation name: ";
                _Body += "\nThreshold: ";
                _Body += "\nChange record: ";
                issue.Body = _Body;
                issue.Provider = Provider;
                issue.Label = "enhancement;";
                setIssueToSession(issue);
                TempData["issue"] = JsonConvert.SerializeObject(issue);
                return RedirectToAction("Edit", "SubmitGitHubIssue");
            }
            if (userAction == "ModifyThreshold")
            {
                issue.Title = Server.Customer + " - Modify threshold on situation for server " + Server.ServerName;
                string _Body = "Modify threshold on situation for server " + Server.ServerName;
                _Body += "\n\nCustomer: " + Server.Customer;
                _Body += "\nOperating System: " + Server.OperatingSystem;
                _Body += "\nEnvironment: " + Server.Environment;
                _Body += "\nSituation name: ";
                _Body += "\nNew threshold: ";
                _Body += "\nChange record: ";
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