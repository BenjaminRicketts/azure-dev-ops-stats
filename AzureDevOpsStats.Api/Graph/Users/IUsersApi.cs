using System.Threading.Tasks;
using AzureDevOpsStats.Api.Graph.Users.Models;
using AzureDevOpsStats.Api.Models;

namespace AzureDevOpsStats.Api.Graph.Users
{
    public interface IUsersApi
    {
        Task<PagedResult<User>> GetUsersAsync(string continuationToken = null, string[] subjectTypes = null);
    }
}