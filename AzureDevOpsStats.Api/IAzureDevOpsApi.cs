using AzureDevOpsStats.Api.Git;
using AzureDevOpsStats.Api.Graph;

namespace AzureDevOpsStats.Api
{
    public interface IAzureDevOpsApi
    {
        IGitApi Git { get; }
        IGraphApi Graph { get; }
    }
}