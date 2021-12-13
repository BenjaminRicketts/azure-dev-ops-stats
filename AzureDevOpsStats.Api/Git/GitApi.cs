using System;
using System.Threading;
using AzureDevOpsStats.Api.Http;

namespace AzureDevOpsStats.Api.Git
{
    public class GitApi : IGitApi
    {
        private readonly Lazy<ICommitApi> _commitsApi;
        private readonly Lazy<IPullRequestsApi> _pullRequestsApi;
        private readonly Lazy<IPushApi> _pushApi;

        internal GitApi(IWebRequestExecutor executor, AzureDevOpsSettings settings)
        {
            _commitsApi = new Lazy<ICommitApi>(() => new CommitApi(executor, settings), LazyThreadSafetyMode.ExecutionAndPublication);
            _pullRequestsApi = new Lazy<IPullRequestsApi>(() => new PullRequestsApi(executor, settings), LazyThreadSafetyMode.ExecutionAndPublication);
            _pushApi = new Lazy<IPushApi>(() => new PushApi(executor, settings), LazyThreadSafetyMode.ExecutionAndPublication);
        }

        public ICommitApi Commits => _commitsApi.Value;
        
        public IPullRequestsApi PullRequests => _pullRequestsApi.Value;

        public IPushApi Pushes => _pushApi.Value;
    }
}