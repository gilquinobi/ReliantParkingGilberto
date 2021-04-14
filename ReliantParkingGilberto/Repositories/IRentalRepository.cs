using ReliantParkingGilberto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReliantParkingGilberto.Repositories
{
    public interface IRentalRepository
    {
        public Resident GetResident(int id);
        public IEnumerable<Resident> GetAllResidents();
        public void AddResident(Resident resident);
        public void UpdateResident(Resident resident);
        public void DeleteResident(int id);
        public ResidentialProperty ResidentialProperty(int id);
        public void UpdateResidentialProperty(ResidentialProperty residentialProperty);
        public void DeleteResidentialProperty(int id);
        public IEnumerable<ResidentialProperty> GetAllResidentialProperty();
        public void AddResidentialProperty(ResidentialProperty residentialProperty);
        public void AddResidentialPropertyType(ResidentialPropertyType residentialPropertyType);
        public IEnumerable<ResidentialPropertyType> GetAllResidentialPropertyTypes();

        
    }
}
