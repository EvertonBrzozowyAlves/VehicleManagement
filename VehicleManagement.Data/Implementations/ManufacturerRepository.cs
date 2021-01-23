using System.Collections.Generic;
using VehicleManagement.Models;

namespace VehicleManagement.Data.Implementations
{
    public class ManufacturerRepository : BaseRepository<Manufacturer>, IManufacturerRepository
    {
		public Manufacturer Get(int id)
		{
			string sql = $@"SELECT 
							 [{nameof(Manufacturer.ManufacturerId)}]
							,[{nameof(Vehicle.IsActive)}]
							,[{nameof(Vehicle.RegisterDate)}]
							,[{nameof(Manufacturer.Name)}]
						FROM
							[VehicleManagement].[dbo].[Manufacturers]
						WHERE
							[{nameof(Manufacturer.ManufacturerId)}] = @{nameof(Manufacturer.ManufacturerId)}";
			Manufacturer manufacturer =  GetById(sql, new Manufacturer() { ManufacturerId = id });
			return manufacturer;
		}

		public IEnumerable<Manufacturer> GetAll()
		{
			string sql = $@"SELECT 
							 [{nameof(Manufacturer.ManufacturerId)}]
							,[{nameof(Vehicle.IsActive)}]
							,[{nameof(Vehicle.RegisterDate)}]
							,[{nameof(Manufacturer.Name)}]
						FROM
							[VehicleManagement].[dbo].[Manufacturers]";

			IEnumerable<Manufacturer> manufacturers = GetAll(sql);
			return manufacturers;
		}
	}
}
