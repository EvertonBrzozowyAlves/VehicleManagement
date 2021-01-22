using System.Collections.Generic;
using VehicleManagement.Models;

namespace VehicleManagement.Business
{
    public interface IVehicleBusiness
    {
        public Vehicle Get(int id);
        public IEnumerable<Vehicle> GetAll();
        public void Save(Vehicle manufacturer);
        public void Delete(int id);
        public void Update(Vehicle manufacturer);
    }
}
