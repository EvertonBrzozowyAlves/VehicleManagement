using System.Collections.Generic;
using System.Linq;
using VehicleManagement.Data;
using VehicleManagement.Models;

namespace VehicleManagement.Business.Implementations
{
    public class VehicleBusiness : IVehicleBusiness
    {
        private readonly IVehicleRepository _vehicleRepository;
        public VehicleBusiness(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Vehicle Get(int id)
        {
            Vehicle vehicle = _vehicleRepository.Get(id);
            return vehicle;
        }

        public IEnumerable<Vehicle> GetAll()
        {
            IEnumerable<Vehicle> vehicles = _vehicleRepository.GetAll();
            return vehicles.Where(v => v.IsActive == true); //only vehicles which were not `deleted`
        }

        public void Save(Vehicle manufacturer)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Vehicle manufacturer)
        {
            throw new System.NotImplementedException();
        }
    }
}
