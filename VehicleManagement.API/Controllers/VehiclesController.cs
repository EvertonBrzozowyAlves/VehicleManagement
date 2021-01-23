using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
        public ActionResult<Vehicle> Get(int id)
        {
            try
            {
                Vehicle vehicle = _vehicleBusiness.Get(id);
                return Ok(vehicle);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        [Route("")]
        public ActionResult <IEnumerable<Vehicle>> GetAll()
        {
            try
            {
                IEnumerable<Vehicle> vehicles = _vehicleBusiness.GetAll();
                return Ok(vehicles);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Update(Vehicle vehicle)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                _vehicleBusiness.Update(vehicle);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        [Route("")]
        public ActionResult Save(Vehicle vehicle)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                _vehicleBusiness.Save(vehicle);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
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
                return StatusCode(500, e.Message);
            }
        }
    }
}
