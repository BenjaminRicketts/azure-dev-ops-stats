namespace AzureDevOpsStats.Api.Git
{
    public interface IGitApi
    {
        ICommitApi Commits { get; }
        IPullRequestsApi PullRequests { get; }
        IPushApi Pushes { get; }
    }
}