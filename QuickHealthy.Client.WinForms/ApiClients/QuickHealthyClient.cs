using QuickHealthy.Client.WinForms.Constants;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace QuickHealthy.Client.WinForms.ApiClient
{
    //generic httpclient
    public class QuickHealthyClient
    {
        private readonly HttpClient _httpClient;

        public QuickHealthyClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //ulr generator. if id != null id adds / + {id} in url
        private static string GetUrlString(string route, int? id = null)
        {
            return id != null ? UrlConstants.BaseUrl + route + "/" + id
                : UrlConstants.BaseUrl + route;
        }

        
        public async Task<T> GetAsync<T>(string route, int? id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(GetUrlString(route, id));
            
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<T>();

            return default;
        }

        public async Task<List<T>> GetAllAsync<T>(string route, int? id = null)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(GetUrlString(route, id));

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<List<T>>();

            return default;
        }

        public async Task<T> CreateAsync<T>(string route, object model)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(GetUrlString(route), model);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<T>();

            return default;
        }

        public async Task<T> UpdateAsync<T>(string route, object model)
        {
            HttpResponseMessage response = await _httpClient.PutAsJsonAsync(GetUrlString(route), model);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<T>();

            return default;
        }

        public async Task<bool> DeleteAsync(string route, int id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync(GetUrlString(route, id));

            if (response.IsSuccessStatusCode &&
                    await response.Content.ReadFromJsonAsync<int?>() == id)
                return true;

            return false;
        }
    }
}
