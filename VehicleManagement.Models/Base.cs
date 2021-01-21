using System;

namespace VehicleManagement.Models
{
    public class Base
    {
        public Base()
        {
            RegisterDate = DateTime.Now;
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime RegisterDate { get; set; }

    }
}
