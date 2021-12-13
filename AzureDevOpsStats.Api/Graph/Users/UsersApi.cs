using System.Net.Http;
using System.Threading.Tasks;
using AzureDevOpsStats.Api.Graph.Users.Models;
using AzureDevOpsStats.Api.Http;
using AzureDevOpsStats.Api.Models;

namespace AzureDevOpsStats.Api.Graph.Users
{
    public class UsersApi : Api, IUsersApi
    {
        internal UsersApi(IWebRequestExecutor executor, AzureDevOpsSettings settings) 
            : base(executor, settings)
        {
        }

        public async Task<PagedResult<User>> GetUsersAsync(string continuationToken = null, string[] subjectTypes = null) =>
            await 
                Executor
                    .ExecuteAsync<PagedResult<User>>(
                        CreateVsspsRequest("_apis/graph/users?api-version=5.1-preview.1")
                            .WithMethod(HttpMethod.Get)
                            .WithJsonContentType()
                            .WithContinuationToken(continuationToken))
                    .ConfigureAwait(false);
    }
}