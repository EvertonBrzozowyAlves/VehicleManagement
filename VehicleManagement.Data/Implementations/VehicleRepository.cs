using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using VehicleManagement.Models;

namespace VehicleManagement.Data.Implementations
{
    public class VehicleRepository : BaseRepository<Vehicle>, IVehicleRepository
    {
        public Vehicle Get(int id)
        {
            string query = $@"SELECT 
	                                  V.[{nameof(Vehicle.VehicleId)}]
	                                , V.[{nameof(Vehicle.IsActive)}]
	                                , V.[{nameof(Vehicle.RegisterDate)}]
	                                , V.[{nameof(Vehicle.Plate)}]
	                                , V.[{nameof(Vehicle.Model)}]
	                                , V.[{nameof(Vehicle.ManufacturerId)}]
	                                , M.[{nameof(Manufacturer.ManufacturerId)}]
	                                , M.[{nameof(Manufacturer.IsActive)}]
	                                , M.[{nameof(Manufacturer.RegisterDate)}]
	                                , M.[{nameof(Manufacturer.Name)}]
                                FROM 
	                                VehicleManagement.dbo.Vehicles      V LEFT JOIN 
                                    VehicleManagement.dbo.Manufacturers M ON V.{nameof(Manufacturer.ManufacturerId)} = M.{nameof(Manufacturer.ManufacturerId)}
                                WHERE 
                                    V.[{nameof(Vehicle.VehicleId)}] = @{nameof(Vehicle.VehicleId)}";

            Vehicle vehicle;
            using (SqlConnection connection = NewConnection())
            {
                vehicle =
                    connection.Query<Vehicle, Manufacturer, Vehicle>(query, (vehicle, manufacturer) =>
                    {
                        vehicle.Manufacturer = manufacturer;
                        return vehicle;
                    },
                    splitOn: "ManufacturerId",
                    param: new Vehicle() { VehicleId = id })
                    .First();
            }
            if (vehicle.ManufacturerId == 0)
            {
                vehicle.ManufacturerId = vehicle.Manufacturer.ManufacturerId;
            }
            return vehicle;
        }

        public IEnumerable<Vehicle> GetAll()
        {
            string query = $@"SELECT 
	                                  V.[{nameof(Vehicle.VehicleId)}]
	                                , V.[{nameof(Vehicle.IsActive)}]
	                                , V.[{nameof(Vehicle.RegisterDate)}]
	                                , V.[{nameof(Vehicle.Plate)}]
	                                , V.[{nameof(Vehicle.Model)}]
	                                , M.[{nameof(Manufacturer.ManufacturerId)}]
	                                , M.[{nameof(Manufacturer.IsActive)}]
	                                , M.[{nameof(Manufacturer.RegisterDate)}]
	                                , M.[{nameof(Manufacturer.Name)}]
                                FROM 
	                                VehicleManagement.dbo.Vehicles      V LEFT JOIN 
                                    VehicleManagement.dbo.Manufacturers M ON V.{nameof(Manufacturer.ManufacturerId)} = M.{nameof(Manufacturer.ManufacturerId)}";

            IEnumerable<Vehicle> vehicles;
            using (SqlConnection connection = NewConnection())
            {
                vehicles =
                    connection.Query<Vehicle, Manufacturer, Vehicle>(query, (vehicle, manufacturer) =>
                    {
                        vehicle.Manufacturer = manufacturer;
                        return vehicle;
                    },
                    splitOn: "ManufacturerId");
            }
            return vehicles;
        }

        public void Save(Vehicle vehicle)
        {
            string query = $@"INSERT INTO [VehicleManagement].[dbo].[Vehicles]
                                   ([{nameof(Vehicle.Plate)}]
                                   ,[{nameof(Vehicle.Manufacturer.ManufacturerId)}]
                                   ,[{nameof(Vehicle.Model)}])
                             VALUES
                                   (@{nameof(Vehicle.Plate)}
                                   ,@{nameof(Vehicle.Manufacturer.ManufacturerId)}
                                   ,@{nameof(Vehicle.Model)})";

            ExecuteNonQuery(query, vehicle);
        }

        public void Update(Vehicle vehicle)
        {
            string query = $@"UPDATE    
                                    [VehicleManagement].[dbo].[Vehicles] 
                                SET 
                                     [{nameof(Vehicle.IsActive)}] = @{nameof(Vehicle.IsActive)}
                                    ,[{nameof(Vehicle.Plate)}] = @{nameof(Vehicle.Plate)}
                                    ,[{nameof(Vehicle.Model)}] = @{nameof(Vehicle.Model)}
                                    ,[{nameof(Vehicle.Manufacturer.ManufacturerId)}] = @{nameof(Vehicle.Manufacturer.ManufacturerId)}
                                WHERE 
                                    [{nameof(Vehicle.VehicleId)}] = @{nameof(Vehicle.VehicleId)}";

            ExecuteNonQuery(query, vehicle);
        }
    }
}
