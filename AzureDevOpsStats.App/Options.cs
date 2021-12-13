using System.Net.Cache;
using CommandLine;

namespace AzureDevOpsStats.App
{
    internal class Options
    {
        [Option('o', "organization", Required = true, HelpText = "Name of the organization that owns the projects")]
        public string Organization { get; set; }
        
        [Option('a', "pat", Required = true, HelpText = "Personal access token used to authenticate against Azure DevOps")]
        public string PersonalAccessToken { get; set; }
        
        [Option('p', "project", Required = true, HelpText = "Name of the project to query")]
        public string Project { get; set; }
        
        [Option('r', "repository", Required = true, HelpText = "Name of repository to query")]
        public string Repository { get; set; }
    }
}