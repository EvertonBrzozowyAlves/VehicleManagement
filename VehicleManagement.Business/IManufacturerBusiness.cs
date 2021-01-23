using System.Collections.Generic;
using VehicleManagement.Models;

namespace VehicleManagement.Business
{
    public interface IManufacturerBusiness
    {
        public IEnumerable<Manufacturer> GetAll();
    }
}
