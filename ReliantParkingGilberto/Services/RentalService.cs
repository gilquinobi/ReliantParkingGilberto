using ReliantParkingGilberto.Entities;
using ReliantParkingGilberto.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReliantParkingGilberto.Services
{
    public class RentalService : IRentalService
    {
        private readonly IRentalRepository _rentalRepository;
        public RentalService(IRentalRepository rentalRepository)
        {
            _rentalRepository = rentalRepository;
        }
        public void AddResident(Resident resident)
        {
            throw new NotImplementedException();
        }

        public void AddResidentialProperty(ResidentialProperty residentialProperty)
        {
            throw new NotImplementedException();
        }

        public void AddResidentialPropertyType(ResidentialPropertyType residentialPropertyType)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ResidentialProperty> GetAllResidentialProperty()
        {
            var result = _rentalRepository.GetAllResidentialProperty();

            return result;
        }

        public IEnumerable<ResidentialPropertyType> GetAllResidentialPropertyTypes()
        {
            var result = _rentalRepository.GetAllResidentialPropertyTypes();

            return result;
        }

        public IEnumerable<Resident> GetAllResidents()
        {
           var result =  _rentalRepository.GetAllResidents();

            return result;
        }

        public Resident GetResident(int id)
        {
            throw new NotImplementedException();
        }

        public ResidentialProperty ResidentialProperty(int id)
        {
            throw new NotImplementedException();
        }
    }
}
