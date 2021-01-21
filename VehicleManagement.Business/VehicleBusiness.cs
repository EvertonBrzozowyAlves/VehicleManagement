using VehicleManagement.Data;
using VehicleManagement.Models;

namespace VehicleManagement.Business
{
    public class VehicleBusiness : IVehicleBusiness
    {
        private readonly IVehicleRepository _vehicleRepository;
        public VehicleBusiness(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public Vehicle GetVehicle(int id)
        {
            //TODO: Some business logic
            return _vehicleRepository.Get(id);
        }
    }
}
