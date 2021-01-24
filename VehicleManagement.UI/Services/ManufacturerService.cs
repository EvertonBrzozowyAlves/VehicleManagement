using System.Collections.Generic;
using System.Text.Json;
using VehicleManagement.Models;

namespace VehicleManagement.UI.Services
{
    public class ManufacturerService
    {
        private static string _baseUrl = System.Environment.GetEnvironmentVariable("API_BASE_URL");
        private static string _url = $@"{_baseUrl}/Manufacturers";
        private static readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, PropertyNamingPolicy = null };
        public static IEnumerable<Manufacturer> GetAll()
        {
            string response = HttpService.Get(_url).Result;
            IEnumerable<Manufacturer> manufacturers = JsonSerializer.Deserialize<IEnumerable<Manufacturer>>(response, _jsonSerializerOptions);
            return manufacturers;
        }
    }
}
