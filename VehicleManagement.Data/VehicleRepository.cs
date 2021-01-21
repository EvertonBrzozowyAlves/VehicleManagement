using VehicleManagement.Models;

namespace VehicleManagement.Data
{
    public class VehicleRepository : RepositoryBase<Vehicle>, IVehicleRepository
    {
        public Vehicle Get(int id)
        {
            return Get(@"SELECT 
							 [Id]
							,[Active]
							,[RegisterDate]
							,[Plate]
							,[Model]
							,[ManufacturerId]
						FROM
							[VehicleManagement].[dbo].[Vehicles]
						WHERE
							[Id] = 1 "
						, new Vehicle() { Id = id });
        }
    }
}
