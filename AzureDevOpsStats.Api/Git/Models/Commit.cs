using System.Text.Json.Serialization;

namespace AzureDevOpsStats.Api.Git.Models
{
    public class Commit
    {
        [JsonPropertyName("comment")]
        public string Comment { get; set; }       
    }
}