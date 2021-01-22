using System.Collections.Generic;
using VehicleManagement.Models;

namespace VehicleManagement.Data
{
    public interface IManufacturerRepository
    {
        public Manufacturer Get(int id);
    }
}
