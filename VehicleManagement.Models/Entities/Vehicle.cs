using System;
using System.ComponentModel.DataAnnotations;

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
        
        [Required]
        [MaxLength(7)]
        [MinLength(7)]
        [RegularExpression(@"[A-Z]{3}[\d]{1}[\w]{1}[\d]{2}", ErrorMessage = "Placa inválida")]
        public string Plate { get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(1)]
        public string Model { get; set; }

        [Required]
        public int ManufacturerId { get; set; }

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
