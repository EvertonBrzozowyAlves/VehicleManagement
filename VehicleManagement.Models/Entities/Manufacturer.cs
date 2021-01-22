using System;

namespace VehicleManagement.Models
{
    public class Manufacturer : Base, IComparable<Manufacturer>
    {
        public Manufacturer()
        {
        }

        public Manufacturer(string name)
        {
            Name = name;
        }
        public int ManufacturerId { get; set; }
        public string Name { get; set; }

        public int CompareTo(Manufacturer other)
        {
            if(other != null)
            {
                return this.Name.CompareTo(other.Name);
            }
            return -1;
        }
    }
}
