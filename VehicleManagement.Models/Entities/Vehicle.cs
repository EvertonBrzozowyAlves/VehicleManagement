using System;

namespace VehicleManagement.Models
{
    public class Vehicle : Base, IComparable<Vehicle>
    {
        public Vehicle() 
        {
        }

        public Vehicle(string plate, string model)
        {
            Plate = plate;
            Model = model;
        }

        public int VehicleId { get; set; }
        public string Plate { get; set; }
        public string Model { get; set; }
        public Manufacturer Manufacturer { get; set; }

        public int CompareTo(Vehicle other)
        {
            if (other != null)
            {
                return this.Plate.CompareTo(other.Plate);
            }
            return -1;
        }
    }
}
