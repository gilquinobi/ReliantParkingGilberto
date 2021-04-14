using Microsoft.EntityFrameworkCore;

namespace ReliantParkingGilberto.Entities
{
    public class RentalDbContext : DbContext
    {
        public RentalDbContext(DbContextOptions<RentalDbContext> options) : base(options)
        {
        }

        public DbSet<Resident> Residents { get; set; }
        public DbSet<ResidentialProperty> ResidentialProperties { get; set; }

        public DbSet<ResidentialPropertyType> ResidentialPropertyTypes { get; set; }




    }
}
