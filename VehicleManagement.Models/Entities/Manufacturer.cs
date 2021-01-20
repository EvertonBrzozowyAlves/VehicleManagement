namespace VehicleManagement.Models
{
    public class Manufacturer : Base
    {
        public Manufacturer()
        {
        }

        public Manufacturer(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
