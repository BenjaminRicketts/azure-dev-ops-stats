using System.Net;
using AzureDevOpsStats.Api.Http;

namespace AzureDevOpsStats.Api
{
    public abstract class Api
    {
        private readonly IWebRequestExecutor _executor;
        private readonly AzureDevOpsSettings _settings;

        protected IWebRequestExecutor Executor => _executor;
        
        protected Api(IWebRequestExecutor executor, AzureDevOpsSettings settings)
        {
            _executor = executor;
            _settings = settings;
        }

        protected HttpWebRequest CreateRequest(string path) =>
            WebRequest
                .CreateHttp($"https://dev.azure.com/{_settings.Organization}/{_settings.Project}/{path.TrimStart('/')}")
                .WithPersonalAccessToken(_settings.PersonalAccessToken);


        protected HttpWebRequest CreateVsspsRequest(string path) =>
            WebRequest
                .CreateHttp($"https://vssps.dev.azure.com/{_settings.Organization}/{path.TrimStart('/')}")
                .WithPersonalAccessToken(_settings.PersonalAccessToken);
    }
}