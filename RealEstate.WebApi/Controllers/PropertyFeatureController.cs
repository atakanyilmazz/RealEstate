using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Service.Abstracts;

namespace RealEstate.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertyFeatureController : Controller
    {
        private readonly IPropertyFeatureService _propertyFeatureService;

        public PropertyFeatureController(IPropertyFeatureService propertyFeatureService)
        {
            _propertyFeatureService = propertyFeatureService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_propertyFeatureService.Get());
        }
    }
}
