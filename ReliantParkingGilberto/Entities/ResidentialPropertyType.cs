using System.ComponentModel.DataAnnotations;

namespace ReliantParkingGilberto.Entities
{
    public class ResidentialPropertyType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }
    }
}
