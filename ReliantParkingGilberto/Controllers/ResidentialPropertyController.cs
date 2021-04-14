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
    public class ResidentialPropertyController : ControllerBase
    {
        private readonly ILogger<ResidentialPropertyController> _logger;
        private readonly IRentalService _rentalService;
        public ResidentialPropertyController(
            IRentalService rentalService,
            ILogger<ResidentialPropertyController> logger)
        {
            _rentalService = rentalService;
            _logger = logger;
        }

        // GET: api/ResidentialProperties
        [HttpGet]
        public IEnumerable<ResidentialProperty> GetResidentialProperties()
        {
            return _rentalService.GetAllResidentialProperty();
        }


    }
}
