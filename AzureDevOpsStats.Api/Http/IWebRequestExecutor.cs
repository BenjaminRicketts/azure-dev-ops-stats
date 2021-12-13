using System.Net;
using System.Threading.Tasks;

namespace AzureDevOpsStats.Api.Http
{
    public interface IWebRequestExecutor
    {
        Task<WebResponse> ExecuteAsync(WebRequest request);
        Task<T> ExecuteAsync<T>(WebRequest request);
    }
}