using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Platform_Services_Portal.Models
{
    public class GitHubIssueModel
    {

        public int IssueID { get; set; }

        [Required]
        public string Title { get; set; }
        public string Body { get; set; }
        public ICollection<string> Labels { get; set; }
        public ICollection<string> Assignees { get; set; }
        public string Label { get; set; }
        public string Assignee { get; set; }
        public string HtmlUrl { get; set; }
        public string Exception { get; set; }
        [Required]
        public string Provider { get; set; }



        public GitHubIssueModel(string Title, string Body, string Provider)
        {
            this.Title = Title;
            this.Body = Body;
            this.Provider = Provider;
        }
        public GitHubIssueModel(string Title, string Body, ICollection<string> Labels, ICollection<string> Assignees, string Provider)
        {
            this.Title = Title;
            this.Body = Body;
            this.Provider = Provider;
            this.Labels = Labels;
            this.Assignees = Assignees;

        }
        public GitHubIssueModel(string Title, string Body, string Label, string Assignee, string Provider)
        {
            this.Title = Title;
            this.Body = Body;
            this.Provider = Provider;
            this.Label = Label;
            this.Assignee = Assignee;

        }
        public GitHubIssueModel() { }

        public override string ToString() => JsonSerializer.Serialize<GitHubIssueModel>(this);


    }
}
