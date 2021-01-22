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
            Vehicle vehicle = _vehicleRepository.Get(id);
            vehicle.IsActive = false; //avoid losing data
            Update(vehicle); 

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

        public void Save(Vehicle vehicle)
        {
            _vehicleRepository.Save(vehicle);
        }

        public void Update(Vehicle vehicle)
        {
            _vehicleRepository.Update(vehicle);

        }
    }
}
