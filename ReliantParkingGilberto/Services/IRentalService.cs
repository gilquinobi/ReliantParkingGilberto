using ReliantParkingGilberto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReliantParkingGilberto.Services
{
    public interface IRentalService
    {
        public Resident GetResident(int id);
        public IEnumerable<Resident> GetAllResidents();
        public void AddResident(Resident resident);
        public ResidentialProperty ResidentialProperty(int id);
        public IEnumerable<ResidentialProperty> GetAllResidentialProperty();
        public void AddResidentialProperty(ResidentialProperty residentialProperty);
        public void AddResidentialPropertyType(ResidentialPropertyType residentialPropertyType);
        public IEnumerable<ResidentialPropertyType> GetAllResidentialPropertyTypes();

    }
}
