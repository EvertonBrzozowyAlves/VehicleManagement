using Microsoft.AspNetCore.Mvc;
using VehicleManagement.Business;
using VehicleManagement.Models;

namespace VehicleManagement.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleBusiness _vehicleBusiness;

        public VehicleController(IVehicleBusiness vehicleBusiness)
        {
            _vehicleBusiness = vehicleBusiness;
        }

        [HttpGet]
        [Route("{id}")]
        public Vehicle Get(int id)
        {
            return _vehicleBusiness.GetVehicle(id);
        }
    }
}
