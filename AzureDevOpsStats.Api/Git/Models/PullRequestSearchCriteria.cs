using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Web;

namespace AzureDevOpsStats.Api.Git.Models
{
    public class PullRequestSearchCriteria
    {
        private static readonly JsonSerializerOptions _options = new()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        };
        
        [JsonPropertyName("searchCriteria.creatorId")]
        public Guid CreaterId { get; set; }
        
        [JsonPropertyName("searchCriteria.includeLinks")]
        public bool IncludeLinks { get; set; }
        
        [JsonPropertyName("searchCriteria.reviewerId")]
        public Guid ReviewerId { get; set; }
        
        [JsonPropertyName("skip")]
        public int Skip { get; set; }
        
        [JsonPropertyName("searchCriteria.sourceRefName")]
        public string SourceBranch { get; set; }
        
        [JsonPropertyName("searchCriteria.sourceRepositoryId")]
        public Guid SourceRepositoryId { get; set; }
        
        [JsonPropertyName("searchCriteria.status")]
        public PullRequestStatus Status { get; set; }
        
        [JsonPropertyName("searchCriteria.targetRefName")]
        public string TargetBranch { get; set; }

        [JsonPropertyName("top")] 
        public int Top { get; set; }

        internal string ToQueryString()
        {
            var json = JsonSerializer.Serialize(this, _options);
            var pairs = JsonSerializer.Deserialize<IDictionary<string, object>>(json);
            return string.Join("&", pairs.Select(pair => $"{pair.Key}={HttpUtility.UrlEncode(pair.Value?.ToString())}"));
        }
    }
}