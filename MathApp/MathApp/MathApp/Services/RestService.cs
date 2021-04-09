using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MathApp.Common;

namespace MathApp.Services
{
    public class RestService : IRestService
    {
        private readonly HttpClient _http;

        public RestService()
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            _http = new HttpClient();
        }

        public async Task<string> Test()
        {
            Uri uri = new Uri(Requests.Test);

            HttpResponseMessage response = await _http.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                //Items = JsonSerializer.Deserialize<List<TodoItem>>(content, serializerOptions);
            }

            return "";
        }
    }
}
