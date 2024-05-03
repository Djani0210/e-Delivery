using e_Delivery.Model.City;
using e_Delivery.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace e_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;
        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpPost("add-city"), Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddCity(CityCreateVM cityCreateVM, CancellationToken cancellationToken)
        {
            var message = await _cityService.CreateCityAsMessageAsync(cityCreateVM, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }
        [HttpGet("get-cities-filtered"), AllowAnonymous]
        public async Task<IActionResult> GetCities(CancellationToken cancellationToken,string? title, int items_per_page = 10, int pageNumber = 1)
        {
            var message= await _cityService.GetCitiesFilteredAsMessageAsync(cancellationToken,title,items_per_page,pageNumber);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }
        [HttpGet("get-cities"), AllowAnonymous]
        public async Task<IActionResult> GetCities(CancellationToken cancellationToken)
        {
            var message = await _cityService.GetCitiesAsMessageAsync(cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpGet("get-city"), Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetCityById(int id, CancellationToken cancellationToken)
        {
            var message = await _cityService.GetCityByAsMessageAsync(id, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpPut("update-city"), Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateCity(int id,updateCityVM cityVM, CancellationToken cancellationToken)
        {
            var message = await _cityService.UpdateCityAsMessageAsync(id,cityVM, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }
    }
}
