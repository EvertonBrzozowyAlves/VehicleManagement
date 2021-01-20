using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManagement.Models
{
    public class Base
    {
        public Base()
        {
            if (RegisterDate == null)
            {
                RegisterDate = DateTime.Now;
            }
        }

        public int Id { get; set; }
        private DateTime RegisterDate { get; set; }

    }
}
