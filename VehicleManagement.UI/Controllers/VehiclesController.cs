using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VehicleManagement.Models;
using VehicleManagement.UI.Models;
using VehicleManagement.UI.Services;

namespace VehicleManagement.UI.Controllers
{
    public class VehiclesController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Vehicle> vehicles = VehicleService.GetAll();
            return View(vehicles);
        }

        public IActionResult Edit(int id)
        {
            if(id == 0)
                return View(new Vehicle());
            Vehicle vehicle = VehicleService.Get(id);
            return View(vehicle);
        }

        [HttpPost]
        public void Delete(int id)
        {
            VehicleService.Delete(id);
        }

        [HttpPost]
        public void Save([FromBody] Vehicle vehicle)
        {
            if (vehicle.VehicleId > 0)
                VehicleService.Update(vehicle);
            else
                VehicleService.Save(vehicle);
        }
    }
}
