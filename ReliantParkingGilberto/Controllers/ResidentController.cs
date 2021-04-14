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
    public class ResidentController : ControllerBase
    {
        private readonly ILogger<ResidentController> _logger;
        private readonly IRentalService _rentalService;
        public ResidentController(
            IRentalService rentalService,
            ILogger<ResidentController> logger)
        {
            _rentalService = rentalService;
            _logger = logger;
        }

        // GET: api/Residents
        [HttpGet]
        public IEnumerable<Resident> GetResidents()
        {
            return _rentalService.GetAllResidents();
        }


    }
}
