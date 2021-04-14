using ReliantParkingGilberto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReliantParkingGilberto.Repositories
{
    public class RentalRepository : IRentalRepository
    {
        private readonly RentalDbContext _dbContext;

        public RentalRepository(RentalDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddResident(Resident resident)
        {
            _dbContext.Residents.Add(resident);
            _dbContext.SaveChanges();

        }

        public void UpdateResident(Resident resident)
        {
            if (!ResidentExists(resident.Id))
            {
                _dbContext.Residents.Update(resident);
                _dbContext.SaveChanges();
            }
        }

        public void DeleteResident(int id)
        {
            if (!ResidentExists(id))
            {
                var resident = _dbContext.Residents.FirstOrDefault(x => x.Id == id);
                _dbContext.Residents.Remove(resident);
                _dbContext.SaveChanges();
            }
        }

        public void AddResidentialProperty(ResidentialProperty residentialProperty)
        {
            _dbContext.ResidentialProperties.Add(residentialProperty);
            _dbContext.SaveChanges();
        }

        public void AddResidentialPropertyType(ResidentialPropertyType residentialPropertyType)
        {
            _dbContext.ResidentialPropertyTypes.Add(residentialPropertyType);
            _dbContext.SaveChanges();
        }

        public IEnumerable<ResidentialProperty> GetAllResidentialProperty()
        {
            var residentialProperties = _dbContext.ResidentialProperties;

            return residentialProperties;
        }

        public IEnumerable<Resident> GetAllResidents()
        {
            var residents = _dbContext.Residents;

            return residents;
        }

        public Resident GetResident(int id)
        {
            var resident = _dbContext.Residents.FirstOrDefault(x => x.Id == id);

            return resident;
        }

        public ResidentialProperty ResidentialProperty(int id)
        {
            var residentialProperty = _dbContext.ResidentialProperties.FirstOrDefault(x => x.Id == id);

            return residentialProperty;
        }

        public void UpdateResidentialProperty(ResidentialProperty resident)
        {
            if (!ResidentialPropertyExists(resident.Id))
            {
                _dbContext.ResidentialProperties.Update(resident);
                _dbContext.SaveChanges();
            }
        }

        public void DeleteResidentialProperty(int id)
        {
            if (!ResidentialPropertyExists(id))
            {
                var residentialProperty = _dbContext.ResidentialProperties.FirstOrDefault(x => x.Id == id);
                _dbContext.ResidentialProperties.Remove(residentialProperty);
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<ResidentialPropertyType> GetAllResidentialPropertyTypes()
        {
            return _dbContext.ResidentialPropertyTypes;
        }

        private bool ResidentExists(int id)
        {
            return _dbContext.Residents.Any(e => e.Id == id);
        }

        private bool ResidentialPropertyExists(int id)
        {
            return _dbContext.ResidentialProperties.Any(e => e.Id == id);
        }

        
    }
}
