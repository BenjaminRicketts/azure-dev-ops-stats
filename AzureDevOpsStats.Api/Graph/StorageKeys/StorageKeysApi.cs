using System.Net.Http;
using System.Threading.Tasks;
using AzureDevOpsStats.Api.Graph.StorageKeys.Models;
using AzureDevOpsStats.Api.Http;

namespace AzureDevOpsStats.Api.Graph.StorageKeys
{
    public class StorageKeysApi : Api, IStorageKeysApi
    {
        public StorageKeysApi(IWebRequestExecutor executor, AzureDevOpsSettings settings) 
            : base(executor, settings)
        {
        }

        public async Task<StorageKey> GetStorageKeyByDescriptor(string descriptor) =>
            await
                Executor
                    .ExecuteAsync<StorageKey>(
                        CreateVsspsRequest($"_apis/graph/storagekeys/{descriptor}?api-version=6.0-preview.1")
                            .WithMethod(HttpMethod.Get))
                    .ConfigureAwait(false);
    }
}