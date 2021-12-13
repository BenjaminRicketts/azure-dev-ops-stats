using System.Threading.Tasks;
using AzureDevOpsStats.Api.Graph.StorageKeys.Models;

namespace AzureDevOpsStats.Api.Graph.StorageKeys
{
    public interface IStorageKeysApi
    {
        Task<StorageKey> GetStorageKeyByDescriptor(string descriptor);
    }
}