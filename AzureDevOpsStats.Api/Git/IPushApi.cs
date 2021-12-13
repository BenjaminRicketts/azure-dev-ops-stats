using System.Threading.Tasks;
using AzureDevOpsStats.Api.Git.Models;
using AzureDevOpsStats.Api.Models;

namespace AzureDevOpsStats.Api.Git
{
    public interface IPushApi
    {
        Task<PagedResult<Push>> GetAsync(string repository);
    }
}