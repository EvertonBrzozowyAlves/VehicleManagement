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

        [JsonIgnore]
        public DateTime RegisterDate { get; set; } //TODO: consider a private set or expand to validate

    }
}
