using System;
using System.ComponentModel.DataAnnotations;

namespace VehicleManagement.Models
{
    public class Vehicle : Base, IComparable<Vehicle>
    {
        #region CONSTRUCTORS

        public Vehicle() 
        {
        }

        public Vehicle(string plate, string model)
        {
            Plate = plate;
            Model = model;
        }

        #endregion

        #region PROPERTIES 

        public int VehicleId { get; set; }
        
        [Required]
        [MaxLength(7, ErrorMessage = "Placa deve ter exatamente 7 caracteres")]
        [MinLength(7, ErrorMessage = "Placa deve ter exatamente 7 caracteres")]
        [RegularExpression(@"[A-Z]{3}[\d]{1}[\w]{1}[\d]{2}", ErrorMessage = "Placa inválida.")]
        public string Plate { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Nome do modelo muito longo.")]
        [MinLength(1, ErrorMessage = "Nome do modelo deve conter ao menos um caractere.")]
        public string Model { get; set; }

        [Required(ErrorMessage = "O identificador da montadora é obrigatório.")]
        public int ManufacturerId { get; set; }

        public Manufacturer Manufacturer { get; set; }

        #endregion

        #region METHODS

        public int CompareTo(Vehicle other)
        {
            if (other != null)
            {
                return this.Plate.CompareTo(other.Plate);
            }
            return -1;
        }

        #endregion
    }
}
