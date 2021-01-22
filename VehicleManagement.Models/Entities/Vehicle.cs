namespace VehicleManagement.Models
{
    public class Vehicle : Base
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
    }
}
