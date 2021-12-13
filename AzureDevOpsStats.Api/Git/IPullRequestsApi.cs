using System.Threading.Tasks;
using AzureDevOpsStats.Api.Git.Models;
using AzureDevOpsStats.Api.Models;

namespace AzureDevOpsStats.Api.Git
{
    public interface IPullRequestsApi
    {
        Task<PagedResult<PullRequest>> Get(string repository, PullRequestSearchCriteria criteria);
    }
}