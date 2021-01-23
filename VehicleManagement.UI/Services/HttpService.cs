using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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

        public static async Task<string> Post(string url, Vehicle vehicle, JsonSerializerOptions serializerOptions = null)
        {
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var teste = JsonSerializer.Serialize<Vehicle>(vehicle, serializerOptions);
            HttpResponseMessage resultado = _client.PostAsync(url, new StringContent(teste, Encoding.UTF8, "application/json")).Result;

            if (resultado.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new HttpRequestException($"{resultado.StatusCode}-{resultado.RequestMessage}");
            }

            //TODO: consider removing
            string response = await resultado.Content.ReadAsStringAsync();
            return response;
        }

        public static async Task<string> Put(string url, Vehicle vehicle, JsonSerializerOptions serializerOptions = null)
        {
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var teste = JsonSerializer.Serialize<Vehicle>(vehicle, serializerOptions);
            HttpResponseMessage resultado = _client.PutAsync(url, new StringContent(teste, Encoding.UTF8, "application/json")).Result;

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
