using System;
using System.Net;
using System.Net.Http;
using System.Text;

namespace AzureDevOpsStats.Api.Http
{
    internal static class WebRequestBuilder
    {
        public static T WithContentType<T>(this T request, string contentType) where T : WebRequest
        {
            request.ContentType = contentType;
            return request;
        }
        
        public static T WithContinuationToken<T>(this T request, string token) where T : WebRequest
        {
            if (token != null)
                request.WithHeader("x-ms-continuationtoken", token);
            return request;
        }

        public static T WithHeader<T>(this T request, HttpRequestHeader header, string value) where T : WebRequest
        {
            request.Headers.Add(header, value);
            return request;
        }
        
        public static T WithHeader<T>(this T request, string name, string value) where T : WebRequest
        {
            request.Headers.Add(name, value);
            return request;
        }

        public static T WithJsonContentType<T>(this T request) where T : WebRequest => request.WithContentType("application/json");
        
        public static T WithMethod<T>(this T request, HttpMethod method) where T : WebRequest
        {
            request.Method = method.ToString();
            return request;
        }

        public static T WithPersonalAccessToken<T>(this T request, string pat) where T : WebRequest
        {
            var credentials = Convert.ToBase64String(Encoding.UTF8.GetBytes($":{pat}"));
            request.WithHeader(HttpRequestHeader.Authorization, $"Basic {credentials}");
            return request;
        }
    }
}