using VehicleManagement.Models;

namespace VehicleManagement.Data
{
    public interface IVehicleRepository
    {
        public Vehicle Get(int id);

    }
}
