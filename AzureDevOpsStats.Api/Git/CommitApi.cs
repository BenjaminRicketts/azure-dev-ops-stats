using System.Net.Http;
using System.Threading.Tasks;
using AzureDevOpsStats.Api.Git.Models;
using AzureDevOpsStats.Api.Http;
using AzureDevOpsStats.Api.Models;

namespace AzureDevOpsStats.Api.Git
{
    public class CommitApi : Api, ICommitApi
    {
        public CommitApi(IWebRequestExecutor executor, AzureDevOpsSettings settings) 
            : base(executor, settings)
        {
        }

        public async Task<PagedResult<Commit>> GetAsync(string repository) =>
            await
                Executor
                    .ExecuteAsync<PagedResult<Commit>>(
                        CreateRequest($"_apis/git/repositories/{repository}/commits?api-version=6.0")
                            .WithMethod(HttpMethod.Get))
                    .ConfigureAwait(false);
    }
}