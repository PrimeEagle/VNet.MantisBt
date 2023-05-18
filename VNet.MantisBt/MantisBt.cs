using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using VNet.Utility;
// ReSharper disable MemberCanBePrivate.Global

namespace VNet.MantisBt
{
    public class MantisBt
    {
        public string AuthenticationToken { get; init; }
        public Uri Uri { get; set; }

        private Uri BaseUri => new Uri(this.Uri.ToString() + "api/rest/");

        public MantisBt(Uri rootUri, string authenticationToken)
        {
            this.AuthenticationToken = authenticationToken;
            this.Uri = rootUri;
        }

        private async Task<T> GetRequest<T>(string urlPortion, IDictionary<string, string> headers = null)
        {
            var uri = this.BaseUri + urlPortion;

            var authHeader = new AuthenticationHeaderValue(this.AuthenticationToken);
            var acceptHeaders = new List<MediaTypeWithQualityHeaderValue> { new("application/json") };

            var result = await WebUtility.Get<T>(new Uri(uri), authHeader, headers, acceptHeaders);

            return result;
        }

        private async Task<HttpResponseMessage> PutRequest<T>(string urlPortion, T content, IDictionary<string, string> headers = null)
        {
            var uri = this.BaseUri + urlPortion;

            var authHeader = new AuthenticationHeaderValue(this.AuthenticationToken);

            var response = await WebUtility.Put<T>(new Uri(uri), content, authHeader, headers, "application/json");

            return response;
        }

        public async Task<Issue> GetIssue(int issueId)
        {
            var issueList = await GetRequest<IssueList>($"issues/{issueId}", null);

            Issue result = null;
            if (issueList is not null && issueList.Issues.Any())
            {
                result = issueList.Issues.First();
            }

            return result;
        }

        public async Task<IssueList> GetIssues(int pageSize, int page)
        {
            var issueList = await GetRequest<IssueList>($"issues?page_size={pageSize}&page={page}", null);

            return issueList;
        }

        public async Task<IssueList> GetIssues(int projectId)
        {
            var issueList = await GetRequest<IssueList>($"issues?project_id={projectId}", null);

            return issueList;
        }

        public async void AddIssueNote(int issueId, string note)
        {
            var issueNote = new IssueNote()
            {
                Text = note
            };

            await PutRequest<IssueNote>($"issues/{issueId}/notes", issueNote, null);
        }

        public async Task<Project> GeProject(int projectId)
        {
            var projectList = await GetRequest<ProjectList>($"projects/{projectId}", null);

            Project result = null;
            if (projectList is not null && projectList.Projects.Any())
            {
                result = projectList.Projects.First();
            }

            return result;
        }

        public async void AddIssue(Issue issue)
        {
            await PutRequest<Issue>($"issues", issue, null);
        }

        public async void AddProject(Project project)
        {
            await PutRequest<Project>($"projects", project, null);
        }

        public async void AddUser(User user)
        {
            await PutRequest<User>($"users", user, null);
        }
    }
}