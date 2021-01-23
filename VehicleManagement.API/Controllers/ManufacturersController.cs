using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleManagement.Business;
using VehicleManagement.Models;

namespace VehicleManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturersController : ControllerBase
    {
        private readonly IManufacturerBusiness _manufacturerBusiness;

        public ManufacturersController(IManufacturerBusiness manufacturerBusiness)
        {
            _manufacturerBusiness = manufacturerBusiness;
        }

        [HttpGet]
        [Route("")]
        public ActionResult GetAll()
        {
            try
            {
                IEnumerable<Manufacturer> manufacturers = _manufacturerBusiness.GetAll();
                return Ok(manufacturers);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }
    }
}
