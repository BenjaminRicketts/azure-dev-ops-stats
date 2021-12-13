using System;
using System.Threading;
using AzureDevOpsStats.Api.Graph.StorageKeys;
using AzureDevOpsStats.Api.Graph.Users;
using AzureDevOpsStats.Api.Http;

namespace AzureDevOpsStats.Api.Graph
{
    public class GraphApi : IGraphApi
    {
        private readonly Lazy<IStorageKeysApi> _storageKeysApi;
        private readonly Lazy<IUsersApi> _usersApi;
        
        internal GraphApi(IWebRequestExecutor executor, AzureDevOpsSettings settings)
        {
            _storageKeysApi = new Lazy<IStorageKeysApi>(() => new StorageKeysApi(executor, settings), LazyThreadSafetyMode.ExecutionAndPublication);
            _usersApi = new Lazy<IUsersApi>(() => new UsersApi(executor, settings), LazyThreadSafetyMode.ExecutionAndPublication);
        }

        public IStorageKeysApi StorageKeys => _storageKeysApi.Value;
        public IUsersApi Users => _usersApi.Value;
    }
}