using e_Delivery.Model.City;
using e_Delivery.Model.Location;
using e_Delivery.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace e_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;
        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpPost("add-location")]
        public async Task<IActionResult> AddLocationAsMessageAsync(LocationCreateVM locationCreateVM, CancellationToken cancellationToken)
        {
            var message = await _locationService.CreateLocationAsMessageAsync(locationCreateVM, cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }
        [HttpGet("get-location")]
        public async Task<IActionResult> GetLocationAsMessageAsync(int Id, CancellationToken cancellationToken)
        {
            var message = await _locationService.GetLocationAsMessageAsync(Id, cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }
        [HttpDelete("delete-location")]
        public async Task<IActionResult> DeleteLocationAsMessageAsync(int Id, CancellationToken cancellationToken)
        {
            var message = await _locationService.DeleteLocationAsMessageAsync(Id, cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }
        [HttpPut("update-location")]
        public async Task<IActionResult> UpdateLocationAsMessageAsync(int Id, LocationUpdateVM locationUpdateVM, CancellationToken cancellationToken)
        {
            var message = await _locationService.UpdateLocationAsMessageAsync(Id, locationUpdateVM, cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }
    }
}
