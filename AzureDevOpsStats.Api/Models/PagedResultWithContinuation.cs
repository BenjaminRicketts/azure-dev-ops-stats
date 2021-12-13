using System.Text.Json.Serialization;

namespace AzureDevOpsStats.Api.Models
{
    public class PagedResultWithContinuation<T> : PagedResult<T>
    {
        public string ContinuationToken { get; set; }
        
        [JsonIgnore] 
        public bool HasMoreItems => ContinuationToken != null;
    }
}