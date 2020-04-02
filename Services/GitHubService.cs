using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Octokit;
using Platform_Services_Portal.Models;


namespace Platform_Services_Portal.Services
{
    public class GitHubService
    {

        // requires using Microsoft.Extensions.Configuration;
        private readonly IConfiguration Configuration;
        readonly GitHubClient client = new GitHubClient(new ProductHeaderValue("nuno-rios"), new Uri("https://github.ibm.com/"));
        string GitHubToken = "5f9846604d247cc370bb48b2cc166cae24dab7f7";
        public GitHubIssueModel GetIssues(string repo)
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            //client.Credentials = new Credentials(Configuration["GitHubToken"]);
            client.Credentials = new Credentials(GitHubToken);
            try
            {
                #region MyRegion
                ////list all the issues in the identified repository
                //var issuesFilter = new SearchIssuesRequest();
                //issuesFilter.Repos.Add(repo);
                //SearchIssuesResult listOfIssues = await client.Search.SearchIssues(issuesFilter);
                //for (int i = 0; i < listOfIssues.TotalCount; i++)
                //{
                //    string issueTitle = listOfIssues.Items[i].Title;
                //}
                ////// The following requests retrieves all of the user's repositories and
                ////var repositories = await client.Repository.GetAllForCurrent();
                ////Repository repository = await client.Repository.Get("shared-platform", "automation-code"); 
                #endregion
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
            return null;
        }

        public async Task<GitHubIssueModel> SettIssue(GitHubIssueModel issue)
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            client.Credentials = new Credentials(GitHubToken);
            try
            {
                #region MyRegion
                //create issue
                var createIssue = new NewIssue(issue.Title);
                createIssue.Body = issue.Body;
                if (issue.Assignees != null)
                {
                    createIssue.Assignees.Add(issue.Assignee);
                }
                if (issue.Label != null)
                {
                    string[] labels = issue.Label.Split(";");
                    for (int i = 0; i < labels.Length - 1; i++)
                    {
                        createIssue.Labels.Add(labels[i]);
                    }
                }
                string[] Repo = issue.Repository.Split("/");
                var result = await client.Issue.Create(Repo[0], Repo[1], createIssue);
                issue.HtmlUrl = result.HtmlUrl;
                issue.IssueID = result.Number;
                return issue;
                #endregion
            }
            catch (Exception ex)
            {
                issue.Exception = ex.Message;
                return issue;
            }
        }
    }
}
