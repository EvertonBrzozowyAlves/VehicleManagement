using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using VehicleManagement.Models;
using VehicleManagement.UI.Services;

namespace VehicleManagement.UI.Controllers
{
    public class VehiclesController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Vehicle> vehicles = VehicleService.GetVehicles();
            return View(vehicles);
        }

        public IActionResult Get(int id)
        {
            Vehicle vehicle = VehicleService.Get(id);
            return View(vehicle);
        }
    }
}
