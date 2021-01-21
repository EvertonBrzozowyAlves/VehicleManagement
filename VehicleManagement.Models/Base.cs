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
        private DateTime RegisterDate { get; set; }

    }
}
