using System.Collections.Generic;
using System.Threading.Tasks;
using AzureDevOpsStats.Api;
using AzureDevOpsStats.Api.Git.Models;
using AzureDevOpsStats.Api.Http;
using CommandLine;

namespace AzureDevOpsStats.App
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await
                Parser
                    .Default
                    .ParseArguments<Options>(args)
                    .WithParsedAsync(async options =>
                    {
                        var settings = new AzureDevOpsSettings
                        {
                            PersonalAccessToken = options.PersonalAccessToken,
                            Organization = options.Organization,
                            Project = options.Project
                        };
                        var executor = new WebRequestExecutor();
                        var api = new AzureDevOpsApi(executor, settings);
                        var users = await api.Graph.Users.GetUsersAsync().ConfigureAwait(false);
                        var pullRequests = await GetPullRequestsAsync(api).ConfigureAwait(false);
                    });
        }

        private static async Task<List<PullRequest>> GetPullRequestsAsync(AzureDevOpsApi api)
        {
            var criteria = new PullRequestSearchCriteria { Top = 100 };
            var pullRequests = new List<PullRequest>();

            do
            {
                var result = await api.Git.PullRequests.Get("test", criteria).ConfigureAwait(false);
                pullRequests.AddRange(result.Items);
                criteria.Skip += criteria.Top;
            } 
            while (pullRequests.Count % criteria.Top == 0);

            return pullRequests;
        }
    }
}