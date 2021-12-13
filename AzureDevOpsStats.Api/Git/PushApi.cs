using System.Net.Http;
using System.Threading.Tasks;
using AzureDevOpsStats.Api.Git.Models;
using AzureDevOpsStats.Api.Http;
using AzureDevOpsStats.Api.Models;

namespace AzureDevOpsStats.Api.Git
{
    public class PushApi : Api, IPushApi
    {
        internal PushApi(IWebRequestExecutor executor, AzureDevOpsSettings settings) 
            : base(executor, settings)
        {
        }

        public async Task<PagedResult<Push>> GetAsync(string repository) =>
            await
                Executor
                    .ExecuteAsync<PagedResult<Push>>(
                        CreateRequest($"_apis/git/repositories/{repository}/pushes?api-version=6.0")
                            .WithMethod(HttpMethod.Get))
                    .ConfigureAwait(false);
    }
}