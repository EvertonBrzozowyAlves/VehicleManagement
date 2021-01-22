using System.Collections.Generic;
using VehicleManagement.Models;

namespace VehicleManagement.Data.Implementations
{
    public class VehicleRepository : BaseRepository<Vehicle>, IVehicleRepository
    {
        public Vehicle Get(int id)
        {
            string query = $@"SELECT 
							     [{nameof(Vehicle.VehicleId)}]
							    ,[{nameof(Vehicle.IsActive)}]
							    ,[{nameof(Vehicle.RegisterDate)}]
							    ,[{nameof(Vehicle.Plate)}]
							    ,[{nameof(Vehicle.Model)}]
							    ,[{nameof(Vehicle.ManufacturerId)}]
						    FROM
							    [VehicleManagement].[dbo].[Vehicles]
						    WHERE
							    [{nameof(Vehicle.VehicleId)}] = @{nameof(Vehicle.VehicleId)}";

            return GetById(query, new Vehicle() { VehicleId = id });
        }

        public IEnumerable<Vehicle> GetAll()
        {
            string query = $@"SELECT 
							     [{nameof(Vehicle.VehicleId)}]
							    ,[{nameof(Vehicle.IsActive)}]
							    ,[{nameof(Vehicle.RegisterDate)}]
							    ,[{nameof(Vehicle.Plate)}]
							    ,[{nameof(Vehicle.Model)}]
							    ,[{nameof(Vehicle.ManufacturerId)}]
						    FROM
							    [VehicleManagement].[dbo].[Vehicles]";

            return GetAll(query);
        }

        public void Save(Vehicle vehicle)
        {
            string query = $@"INSERT INTO [VehicleManagement].[dbo].[Vehicles]
                                   ([{nameof(Vehicle.IsActive)}]
                                   ,[{nameof(Vehicle.RegisterDate)}]
                                   ,[{nameof(Vehicle.Plate)}]
                                   ,[{nameof(Vehicle.Model)}]
                                   ,[{nameof(Vehicle.ManufacturerId)}])
                             VALUES
                                   (@{nameof(Vehicle.IsActive)}
                                   ,@{nameof(Vehicle.RegisterDate)}
                                   ,@{nameof(Vehicle.Plate)}
                                   ,@{nameof(Vehicle.Model)}
                                   ,@{nameof(Vehicle.ManufacturerId)})";

            ExecuteNonQuery(query, vehicle);
        }

        public void Update(Vehicle vehicle)
        {
            string query = $@"UPDATE [VehicleManagement].[dbo].[Vehicles] SET 
                                     [{nameof(Vehicle.IsActive)}] = @{nameof(Vehicle.IsActive)}
                                    ,[{nameof(Vehicle.RegisterDate)}] = @{nameof(Vehicle.RegisterDate)}
                                    ,[{nameof(Vehicle.Plate)}] = @{nameof(Vehicle.Plate)}
                                    ,[{nameof(Vehicle.Model)}] = @{nameof(Vehicle.Model)}
                                    ,[{nameof(Vehicle.ManufacturerId)}] = @{nameof(Vehicle.ManufacturerId)}
                              WHERE [{nameof(Vehicle.VehicleId)}] = @{nameof(Vehicle.VehicleId)}";

            ExecuteNonQuery(query, vehicle);
        }
        public void Delete(int id)
        {
            string query = $@"UPDATE [VehicleManagement].[dbo].[Vehicles] SET [{nameof(Vehicle.IsActive)}] = 0 WHERE [{nameof(Vehicle.VehicleId)}] = @{nameof(Vehicle.VehicleId)}";
            ExecuteNonQuery(query, new Vehicle() { VehicleId = id });
        }
    }
}
