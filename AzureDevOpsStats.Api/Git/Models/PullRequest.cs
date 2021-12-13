using System;
using System.Text.Json.Serialization;

namespace AzureDevOpsStats.Api.Git.Models
{
    public class PullRequest
    {
        [JsonPropertyName("artifactId")]
        public string ArtifactId { get; set; }
        
        [JsonPropertyName("closedBy")]
        public Identity ClosedBy { get; set; }
        
        [JsonPropertyName("closedDate")]
        public DateTime ClosedDate { get; set; }
        
        [JsonPropertyName("codeReviewId")]
        public int CodeReviewId { get; set; }
        
        [JsonPropertyName("createdBy")]
        public Identity CreatedBy { get; set; }
        
        [JsonPropertyName("creationDate")]
        public DateTime CreatedDate { get; set; }
        
        [JsonPropertyName("description")]
        public string Description { get; set; }
        
        [JsonPropertyName("hasMultipleMergeBases")]
        public bool HasMultipleMergeBases { get; set; }
        
        [JsonPropertyName("pullRequestId")]
        public int Id { get; set; }
        
        [JsonPropertyName("isDraft")]
        public bool IsDraft { get; set; }
        
        [JsonPropertyName("mergeFailureMessage")]
        public string MergeFailureMessage { get; set; }
        
        [JsonPropertyName("mergeId")]
        public string MergeId { get; set; }
        
        [JsonPropertyName("remoteUrl")]
        public string RemoteUrl { get; set; }
        
        [JsonPropertyName("sourceRefName")]
        public string SourceBranchName { get; set; }
        
        [JsonPropertyName("supportsIterations")]
        public bool SupportIterations { get; set; }
        
        [JsonPropertyName("targetRefName")]
        public string TargetBranchName { get; set; }
        
        [JsonPropertyName("title")]
        public string Title { get; set; }
        
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}