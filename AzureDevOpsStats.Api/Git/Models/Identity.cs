using System.Text.Json.Serialization;

namespace AzureDevOpsStats.Api.Git.Models
{
    public class Identity
    {
        [JsonPropertyName("descriptor")]
        public string Descriptor { get; set; }
        
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
        
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
        [JsonPropertyName("isDeletedInOrigin")]
        public bool IsDeletedInOrigin { get; set; }
        
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}