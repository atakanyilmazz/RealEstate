using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Service.Abstracts;

namespace RealEstate.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : Controller
    {
        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet("countries")]
        public IActionResult GetCountries()
        {
            return Ok(_locationService.GetCountries());
        }

        [HttpGet("cities/{countryId}")]
        public IActionResult GetCities(int countryId)
        {
            return Ok(_locationService.GetCities(countryId));
        }

        [HttpGet("districts/{cityId}")]
        public IActionResult GetDistricts(int cityId)
        {
            return Ok(_locationService.GetDistricts(cityId));
        }
    }
}
