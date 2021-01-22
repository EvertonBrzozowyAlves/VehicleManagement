using Microsoft.Extensions.DependencyInjection;
using VehicleManagement.Business;
using VehicleManagement.Business.Implementations;
using VehicleManagement.Data;
using VehicleManagement.Data.Implementations;

namespace VehicleManagement.Configuration
{
	public static class DependencyInjection
	{
		/// <summary>
		/// Register a concrete class for each interface in the system
		/// </summary>
		/// <param name="services"></param>
		public static void RegisterDependencies(this IServiceCollection services)
		{
			services.AddSingleton<IVehicleRepository, VehicleRepository>();
			services.AddSingleton<IManufacturerRepository, ManufacturerRepository>();
			services.AddSingleton<IVehicleBusiness, VehicleBusiness>();
		}
	}
}
