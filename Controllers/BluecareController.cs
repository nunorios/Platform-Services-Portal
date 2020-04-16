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
    public class BluecareController : Controller
    {
        IConfiguration Configuration;
        string Provider = "HST";

        public BluecareController(IConfiguration configuration)
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

        [Route("/Bluecare/Index/{userAction},{serverName}")]
        public async Task<IActionResult> Bluecare(string userAction, string serverName)
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
            if (userAction == "ServiceResponsability")
            {
                issue.Title = Server.Customer + " - Configure new service responsability for server " + Server.ServerName;
                string _Body = "Configure new service responsability for server " + Server.ServerName;
                _Body += "\n\nCustomer: " + Server.Customer;
                _Body += "\nOperating System: " + Server.OperatingSystem;
                _Body += "\nEnvironment: " + Server.Environment;
                _Body += "\nSeverity value: ";
                _Body += "\nChange record: ";
                issue.Body = _Body;
                issue.Provider = Provider;
                issue.Label = "enhancement;";
                setIssueToSession(issue);
                TempData["issue"] = JsonConvert.SerializeObject(issue);
                return RedirectToAction("Edit", "SubmitGitHubIssue");
            }
            if (userAction == "NewNode")
            {
                issue.Title = Server.Customer + " - Create new bluecare node for server " + Server.ServerName;
                string _Body = "Create new bluecare node for server " + Server.ServerName;
                _Body += "\n\nCustomer: " + Server.Customer;
                _Body += "\nOperating System: " + Server.OperatingSystem;
                _Body += "\nEnvironment: " + Server.Environment;
                _Body += "\nIP: ";
                _Body += "\nAlert source: ";
                _Body += "\nChange record:";
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