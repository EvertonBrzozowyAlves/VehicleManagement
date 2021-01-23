using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using VehicleManagement.Models;

namespace VehicleManagement.UI.Services
{
    public class HttpService 
    {
        private static readonly HttpClient _client = new HttpClient();

        public static async Task<string> Get(string url) //OK
        {
            HttpResponseMessage resultado = await _client.GetAsync(url);
            if (resultado.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new HttpRequestException($"{resultado.StatusCode}-{resultado.RequestMessage}");
            }

            string response = await resultado.Content.ReadAsStringAsync();
            return response;
        }

        public static async Task<string> Post(string url, Base model)
        {
            HttpResponseMessage resultado = await _client.PostAsJsonAsync(url, model);
            if (resultado.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new HttpRequestException($"{resultado.StatusCode}-{resultado.RequestMessage}");
            }

            //TODO: consider removing
            string response = await resultado.Content.ReadAsStringAsync();
            return response;
        }

        public static async Task<string> Put(string url, Base model, JsonSerializerOptions serializerOptions = null) //TODO: FIX!
        {
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, url);
            request.Content = new StringContent(model.ToString(), Encoding.UTF8, "application/json");

            

            HttpResponseMessage resultado = _client.SendAsync(request).Result;      

            if (resultado.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new HttpRequestException($"{resultado.StatusCode}-{resultado.RequestMessage}");
            }

            //TODO: consider removing
            string response = await resultado.Content.ReadAsStringAsync();
            return response;
        }

        public static async Task<string> Delete(string url) 
        {
            HttpResponseMessage resultado = await _client.DeleteAsync(url);
            if (resultado.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new HttpRequestException($"{resultado.StatusCode}-{resultado.RequestMessage}");
            }

            //TODO: consider removing
            string response = await resultado.Content.ReadAsStringAsync();
            return response;
        }
    }
}
