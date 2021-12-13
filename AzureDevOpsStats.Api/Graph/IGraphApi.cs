using AzureDevOpsStats.Api.Graph.StorageKeys;
using AzureDevOpsStats.Api.Graph.Users;

namespace AzureDevOpsStats.Api.Graph
{
    public interface IGraphApi
    {
        IStorageKeysApi StorageKeys { get; }
        IUsersApi Users { get; }
    }
}