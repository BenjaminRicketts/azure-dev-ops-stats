using System.Text.Json.Serialization;

namespace AzureDevOpsStats.Api.Graph.StorageKeys.Models
{
    public class StorageKey
    {
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}