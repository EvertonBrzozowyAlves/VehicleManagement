using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using VehicleManagement.Models;

namespace VehicleManagement.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly ILogger<VehicleController> _logger;

        public VehicleController(ILogger<VehicleController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("")]

        public IEnumerable<Vehicle> Read()
        {
            return new List<Vehicle>()
            {
                new Vehicle("AAA0000", "Sedan", 1),
                new Vehicle("AAA0000", "Hatch", 2),
            };
        }

        [HttpGet]
        [Route("{id}")]
        public IEnumerable<Vehicle> Read(int id)
        {
            return new List<Vehicle>()
            {
                new Vehicle("AAA0000", "Sedan", 1),
            };
        }
    }
}
