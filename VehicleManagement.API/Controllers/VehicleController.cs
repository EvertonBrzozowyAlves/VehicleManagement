using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using VehicleManagement.Business;
using VehicleManagement.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

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
        public ActionResult Get(int id)
        {
            try
            {
                Vehicle vehicle = _vehicleBusiness.Get(id);
                return Ok(vehicle);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }

        [HttpGet]
        [Route("")]
        public ActionResult GetAll()
        {
            try
            {
                IEnumerable<Vehicle> vehicles = _vehicleBusiness.GetAll();
                return Ok(vehicles.ToList());
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Update(int id, Vehicle vehicle)
        {
            try
            {
                _vehicleBusiness.Update(vehicle);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }

        [HttpPost]
        [Route("")]
        public ActionResult Save(Vehicle vehicle)
        {
            try
            {
                _vehicleBusiness.Save(vehicle);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _vehicleBusiness.Delete(id);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }
    }
}
