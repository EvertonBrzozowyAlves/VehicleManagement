using System;

namespace VehicleManagement.Models
{
    public class Base
    {
        public Base()
        {
            RegisterDate = DateTime.Now;
        }

        public bool IsActive { get; set; }
        public DateTime RegisterDate { get; set; }

    }
}
