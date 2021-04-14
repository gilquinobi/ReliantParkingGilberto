using System.ComponentModel.DataAnnotations;

namespace ReliantParkingGilberto.Entities
{
    public class Resident
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public ResidentialProperty ResidentialProperty { get; set; }
    }
}
