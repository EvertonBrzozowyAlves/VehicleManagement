using VehicleManagement.Models;

namespace VehicleManagement.Data.Implementations
{
    public class ManufacturerRepository : BaseRepository<Manufacturer>, IManufacturerRepository
    {
		public Manufacturer Get(int id)
		{
			return GetById($@"SELECT 
							 [{nameof(Manufacturer.ManufacturerId)}]
							,[{nameof(Vehicle.IsActive)}]
							,[{nameof(Vehicle.RegisterDate)}]
							,[{nameof(Manufacturer.Name)}]
						FROM
							[VehicleManagement].[dbo].[Manufacturers]
						WHERE
							[{nameof(Manufacturer.ManufacturerId)}] = @{nameof(Manufacturer.ManufacturerId)}"
						, new Manufacturer() { ManufacturerId = id });
		}
	}
}
