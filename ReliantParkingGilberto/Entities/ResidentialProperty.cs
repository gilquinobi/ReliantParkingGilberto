using System.ComponentModel.DataAnnotations;

namespace ReliantParkingGilberto.Entities
{
    public class ResidentialProperty
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Bedrooms { get; set; }

        public ResidentialPropertyType ResidentialPropertyType { get; set; }
    }
}
