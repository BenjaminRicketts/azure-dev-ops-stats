using System.Net.Http;
using System.Threading.Tasks;
using AzureDevOpsStats.Api.Git.Models;
using AzureDevOpsStats.Api.Http;
using AzureDevOpsStats.Api.Models;

namespace AzureDevOpsStats.Api.Git
{
    public class PullRequestsApi : Api, IPullRequestsApi
    {
        public PullRequestsApi(IWebRequestExecutor executor, AzureDevOpsSettings settings) 
            : base(executor, settings)
        {
        }

        public async Task<PagedResult<PullRequest>> Get(string repository, PullRequestSearchCriteria criteria) =>
            await
                Executor
                    .ExecuteAsync<PagedResult<PullRequest>>(
                        CreateRequest($"_apis/git/repositories/{repository}/pullrequests?api-version=6.1-preview.1&{criteria.ToQueryString()}")
                            .WithMethod(HttpMethod.Get))
                    .ConfigureAwait(false);
    }
}