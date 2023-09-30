using Microsoft.AspNetCore.Mvc;
using RealEstate.Common.Dto;
using RealEstate.Service.Abstracts;

namespace RealEstate.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertiesController : Controller
    {
        private readonly IPropertiesService _propertiesService;

        public PropertiesController(IPropertiesService propertiesService)
        {
            _propertiesService = propertiesService;
        }

        [HttpPost]
        public IActionResult Get(SearchPropertyDto model)
        {
            return Ok(_propertiesService.Get(model));
        }

        [HttpGet("GetRooms")]
        public IActionResult GetRooms()
        {
            return Ok(_propertiesService.GetRooms());
        }

        [HttpPost("create")]
        public IActionResult CreateProperty(CreatePropertyDto model)
        {
            var response = _propertiesService.Create(model);
            if (response)
                return Ok(response);
            return Ok("Hata Oluştu");
        }
    }
}
