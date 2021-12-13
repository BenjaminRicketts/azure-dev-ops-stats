using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AzureDevOpsStats.Api.Models
{
    public class PagedResult<T>
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("value")]
        public IEnumerable<T> Items { get; set; }
    }
}