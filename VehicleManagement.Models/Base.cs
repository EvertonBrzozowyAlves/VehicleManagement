using System;
using System.Text.Json.Serialization;

namespace VehicleManagement.Models
{
    public class Base
    {
        public Base()
        {
        }

        [JsonIgnore]
        public bool IsActive { get; set; }
    }
}
