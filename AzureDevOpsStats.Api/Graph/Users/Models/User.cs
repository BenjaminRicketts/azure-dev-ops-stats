using System.Text.Json.Serialization;

namespace AzureDevOpsStats.Api.Graph.Users.Models
{
    public class User
    {
        [JsonPropertyName("descriptor")]
        public string Descriptor { get; set; }
        
        [JsonPropertyName("directoryAlias")]
        public string DirectoryAlias { get; set; }
        
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
        
        [JsonPropertyName("domain")]
        public string Domain { get; set; }
        
        [JsonPropertyName("mailAddress")]
        public string EmailAddress { get; set; }
        
        [JsonPropertyName("isDeletedInOrigin")]
        public bool IsDeletedInOrigin { get; set; }
        
        [JsonPropertyName("legacyDescriptor")]
        public string LegacyDescriptor { get; set; }
        
        [JsonPropertyName("metaType")]
        public string MetaType { get; set; }
        
        [JsonPropertyName("origin")]
        public string Origin { get; set; }
        
        [JsonPropertyName("originId")]
        public string OriginId { get; set; }
        
        [JsonPropertyName("principalName")]
        public string PrincipleName { get; set; }
        
        [JsonPropertyName("subjectKind")]
        public string SubjectKind { get; set; }
    }
}