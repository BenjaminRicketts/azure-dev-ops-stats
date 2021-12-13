using System.IO;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace AzureDevOpsStats.Api.Http
{
    public class WebRequestExecutor : IWebRequestExecutor
    {
        public async Task<WebResponse> ExecuteAsync(WebRequest request) => await request.GetResponseAsync().ConfigureAwait(false);
        
        public async Task<T> ExecuteAsync<T>(WebRequest request)
        {
            var response = await ExecuteAsync(request).ConfigureAwait(false);
            
            using var reader = new StreamReader(response.GetResponseStream());
            var json = await reader.ReadToEndAsync().ConfigureAwait(false);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}