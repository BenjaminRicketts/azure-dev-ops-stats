using System;
using System.Threading;
using AzureDevOpsStats.Api.Git;
using AzureDevOpsStats.Api.Graph;
using AzureDevOpsStats.Api.Http;

namespace AzureDevOpsStats.Api
{
    public class AzureDevOpsApi : IAzureDevOpsApi
    {
        private readonly IWebRequestExecutor _executor;
        private readonly Lazy<IGitApi> _gitApi;
        private readonly Lazy<IGraphApi> _graphApi;
        
        public AzureDevOpsApi(IWebRequestExecutor executor, AzureDevOpsSettings settings)
        {
            _executor = executor;
            _gitApi = new Lazy<IGitApi>(() => new GitApi(executor, settings), LazyThreadSafetyMode.ExecutionAndPublication);
            _graphApi = new Lazy<IGraphApi>(() => new GraphApi(executor, settings), LazyThreadSafetyMode.ExecutionAndPublication);
        }

        public IGitApi Git => _gitApi.Value;
        public IGraphApi Graph => _graphApi.Value;
    }
}