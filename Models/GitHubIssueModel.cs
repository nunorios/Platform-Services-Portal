using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;
using Octokit;

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
        public string Repository { get; set; }
       
        
        
        public GitHubIssueModel(string Title, string Body, string Repository)
        {
            this.Title = Title;
            this.Body = Body;
            this.Repository = Repository;
        }
        public GitHubIssueModel(string Title, string Body, ICollection<string> Labels, ICollection<string> Assignees, string Repository)
        {
            this.Title = Title;
            this.Body = Body;
            this.Repository = Repository;
            this.Labels = Labels;
            this.Assignees = Assignees;

        }
        public GitHubIssueModel(string Title, string Body, string Label, string Assignee, string Repository)
        {
            this.Title = Title;
            this.Body = Body;
            this.Repository = Repository;
            this.Label = Label;
            this.Assignee = Assignee;

        }
        public GitHubIssueModel() { }

        
    }
}
