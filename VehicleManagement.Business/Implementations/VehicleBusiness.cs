using System.Collections.Generic;
using System.Linq;
using VehicleManagement.Data;
using VehicleManagement.Models;

namespace VehicleManagement.Business.Implementations
{
    public class VehicleBusiness : IVehicleBusiness
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IManufacturerRepository _manufacturerRepository;
        public VehicleBusiness(IVehicleRepository vehicleRepository, IManufacturerRepository manufacturerRepository)
        {
            _vehicleRepository = vehicleRepository;
            _manufacturerRepository = manufacturerRepository;
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Vehicle Get(int id)
        {
            Vehicle vehicle = _vehicleRepository.Get(id);
            vehicle.Manufacturer = _manufacturerRepository.Get(vehicle.ManufacturerId);
            return vehicle;
        }

        public IEnumerable<Vehicle> GetAll()
        {
            IEnumerable<Vehicle> vehicles = _vehicleRepository.GetAll();
            vehicles = vehicles.Where(v => v.IsActive == true);
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Manufacturer = _manufacturerRepository.Get(vehicle.ManufacturerId);
            }
            return vehicles;
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
