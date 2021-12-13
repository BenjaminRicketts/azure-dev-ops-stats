using System;
using System.Text.Json.Serialization;

namespace AzureDevOpsStats.Api.Git.Models
{
    public class Push
    {
        [JsonPropertyName("commits")]
        public Commit[] Commits { get; set; }
        
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
        
        [JsonPropertyName("pushedBy")]
        public Identity PushedBy { get; set; }
        
        [JsonPropertyName("pushId")]
        public int PushId { get; set; }
    }
}