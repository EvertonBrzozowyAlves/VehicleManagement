using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using VehicleManagement.Models;

namespace VehicleManagement.UI.Services
{
    public class VehicleService
    {
        private const string _url = "https://localhost:44348/api/Vehicles";
        private static readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, PropertyNamingPolicy = null };
        public static IEnumerable<Vehicle> GetVehicles()
        {
            string response = HttpService.Get(_url).Result;
            IEnumerable<Vehicle> vehicles = JsonSerializer.Deserialize<IEnumerable<Vehicle>>(response, _jsonSerializerOptions);
            return vehicles;
        }

        public static Vehicle Get(int id)
        {
            string response = HttpService.Get($@"{_url}/{id}").Result;
            Vehicle vehicle = JsonSerializer.Deserialize<Vehicle>(response, _jsonSerializerOptions);
            return vehicle;
        }
    }
}
