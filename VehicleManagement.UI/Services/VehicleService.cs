using System.Collections.Generic;
using System.Text.Json;
using VehicleManagement.Models;

namespace VehicleManagement.UI.Services
{
    public class VehicleService
    {
        private const string _url = "https://localhost:44348/api/Vehicles";
        private static readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, IncludeFields = true };
        public static IEnumerable<Vehicle> GetAll()
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
        
        public static void Update(Vehicle vehicle)
        {
            string response = HttpService.Put($@"{_url}/{vehicle.VehicleId}", vehicle, _jsonSerializerOptions).Result; //TODO: consider refactoring
        }

        public static void Save(Vehicle vehicle)
        {
            string response = HttpService.Post($@"{_url}", vehicle).Result; //TODO: consider refactoring
        }
        public static void Delete(int id)
        {
            string response = HttpService.Delete($@"{_url}/{id}").Result; //TODO: consider refactoring
        }
    }
}
