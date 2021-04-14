using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReliantParkingGilberto.Entities;
using ReliantParkingGilberto.Services;

namespace ReliantParkingGilberto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResidentialPropertyTypeController : ControllerBase
    {
        private readonly ILogger<ResidentialPropertyTypeController> _logger;
        private readonly IRentalService _rentalService;
        public ResidentialPropertyTypeController(
            IRentalService rentalService,
            ILogger<ResidentialPropertyTypeController> logger)
        {
            _rentalService = rentalService;
            _logger = logger;
        }

        // GET: api/ResidentialPropertyTypes
        [HttpGet]
        public IEnumerable<ResidentialPropertyType> GetResidentialPropertyTypes()
        {
            return _rentalService.GetAllResidentialPropertyTypes();
        }

    }
}
