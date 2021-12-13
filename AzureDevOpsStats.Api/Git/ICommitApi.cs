using System.Threading.Tasks;
using AzureDevOpsStats.Api.Git.Models;
using AzureDevOpsStats.Api.Models;

namespace AzureDevOpsStats.Api.Git
{
    public interface ICommitApi
    {
        Task<PagedResult<Commit>> GetAsync(string repository);
    }
}