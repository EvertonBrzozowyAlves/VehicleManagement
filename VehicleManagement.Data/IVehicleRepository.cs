using System.Collections.Generic;
using VehicleManagement.Models;

namespace VehicleManagement.Data
{
    public interface IVehicleRepository
    {
        public Vehicle Get(int id);
        public IEnumerable<Vehicle> GetAll();
        public void Save(Vehicle vehicle);
        public void Update(Vehicle vehicle);
    }
}
