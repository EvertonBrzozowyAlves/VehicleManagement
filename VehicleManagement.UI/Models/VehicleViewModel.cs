using System.Collections.Generic;
using VehicleManagement.Models;

namespace VehicleManagement.UI.Models
{
    public class VehicleViewModel
    {
        public Vehicle Vehicle { get; set; }
        public IEnumerable<Manufacturer> Manufacturers { get; set; }
    }
}
