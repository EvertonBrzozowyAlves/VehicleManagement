using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
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
            return _vehicleBusiness.Get(id);
        }

        [HttpGet]
        [Route("")]
        public List<Vehicle> GetAll()
        {
            IEnumerable<Vehicle> vehicles = _vehicleBusiness.GetAll();
            return vehicles.ToList();
        }

        [HttpPut]
        [Route("{id}")]
        public void Update(int id, Vehicle vehicle)
        {
            //TODO
        }
    }
}
