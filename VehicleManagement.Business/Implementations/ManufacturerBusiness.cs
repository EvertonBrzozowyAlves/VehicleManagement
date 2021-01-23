using System.Collections.Generic;
using System.Linq;
using VehicleManagement.Data;
using VehicleManagement.Models;

namespace VehicleManagement.Business.Implementations
{
    public class ManufacturerBusiness : IManufacturerBusiness
    {
        private readonly IManufacturerRepository _manufacturerRepository;

        public ManufacturerBusiness(IManufacturerRepository manufacturerRepository)
        {
            _manufacturerRepository = manufacturerRepository;
        }

        public IEnumerable<Manufacturer> GetAll()
        {
            IEnumerable<Manufacturer> manufacturers = _manufacturerRepository.GetAll();
            return manufacturers.Where(manufacturer => manufacturer.IsActive == true);
        }
    }
}
