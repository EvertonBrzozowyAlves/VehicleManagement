using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using VehicleManagement.Business;
using VehicleManagement.Models;

namespace VehicleManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehicleBusiness _vehicleBusiness;

        public VehiclesController(IVehicleBusiness vehicleBusiness)
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

        [HttpPost]
        [Route("")]
        public void Save(int id, Vehicle vehicle)
        {
            //TODO
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id, Vehicle vehicle)
        {
            //TODO
        }
    }
}
