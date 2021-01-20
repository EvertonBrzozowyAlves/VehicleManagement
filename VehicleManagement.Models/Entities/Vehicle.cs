namespace VehicleManagement.Models
{
    public class Vehicle : Base
    {
        public Vehicle()
        {
        }

        public Vehicle(string plate, string model, int manufacturerId)
        {
            Plate = plate;
            Model = model;
            ManufacturerId = manufacturerId;
        }

        public string Plate { get; set; }
        public string Model { get; set; }
        public int ManufacturerId { get; set; }
    }
}
