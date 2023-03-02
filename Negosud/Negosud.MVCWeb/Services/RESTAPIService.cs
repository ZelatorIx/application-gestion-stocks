﻿using Negosud.MVCWeb.Types;
using Newtonsoft.Json;

namespace Negosud.MVCWeb.Services
{
    public class RESTAPIService
    {
        private readonly string backendUrl;
        private readonly HttpClient httpClient = new HttpClient();

        public RESTAPIService()
        {
            backendUrl = "https://localhost:7049";
        }

        public async Task<T?> Get<T>(string route)
        {
            string url = $"{backendUrl}/{route}";
            string json = await httpClient.GetStringAsync(url);

            return JsonConvert.DeserializeObject<T>(json);
        }

        public async Task<HttpResponseMessage> Post<T>(string route, T body)
        {
            string url = $"{backendUrl}/{route}";

            return await httpClient.PostAsJsonAsync(url, body);
        }

        public async Task<HttpResponseMessage> Put<T>(string route, T body)
        {
            string url = $"{backendUrl}/{route}";

            return await httpClient.PutAsJsonAsync(url, body);
        }

        public async Task<HttpResponseMessage> Delete(string route)
        {
            return await httpClient.DeleteAsync(route);
        }
    }
}