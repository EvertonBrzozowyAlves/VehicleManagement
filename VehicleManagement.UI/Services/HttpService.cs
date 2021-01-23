using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace VehicleManagement.UI.Services
{
    public class HttpService 
    {
        private static readonly HttpClient _client = new HttpClient();

        public HttpClient CreateClient(string name)
        {
            throw new NotImplementedException();
        }

        public static async Task<string> Get(string url)
        {
            HttpResponseMessage resultado = await _client.GetAsync(url);
            if (resultado.StatusCode != System.Net.HttpStatusCode.OK)
                throw new HttpRequestException($"{resultado.StatusCode}-{resultado.RequestMessage}");

            string response = await resultado.Content.ReadAsStringAsync();
            return response;
        }
    }
}
