using e_Delivery.Model.City;
using e_Delivery.Model.SideDish;
using e_Delivery.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace e_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SideDishController : ControllerBase
    {
        private readonly ISideDishService _sideDishService;
        public SideDishController(ISideDishService sideDishService)
        {
            _sideDishService = sideDishService;
        }

        [HttpPost("add-SideDish"), Authorize(Roles = "Desktop")]
        public async Task<IActionResult> AddSideDish(CreateSideDishVM createSideDishVM, CancellationToken cancellationToken)
        {
            var message = await _sideDishService.CreateSideDishAsMessageAsync(createSideDishVM, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpPut("update-SideDish"), Authorize(Roles = "Desktop")]
        public async Task<IActionResult> UpdateSideDish(int id ,UpdateSideDishVM updateSideDishVM, CancellationToken cancellationToken)
        {
            var message = await _sideDishService.UpdateSideDishAsMessageAsync(id, updateSideDishVM, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpGet("get-SideDishes"), Authorize(Roles = "Desktop")]
        public async Task<IActionResult> GetSideDishes(CancellationToken cancellationToken)
        {
            var message= await _sideDishService.GetSideDishesByRestaurantAsMessageAsync(cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpGet("get-SideDish-By-Id"), Authorize(Roles = "Desktop")]
        public async Task<IActionResult> GetSideDishById(int id, CancellationToken cancellationToken)
        {
            var message = await _sideDishService.GetSideDishByIdAsMessageAsync(id,cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpDelete("delete-SideDish"), Authorize(Roles = "Desktop")]
        public async Task<IActionResult> DeleteSideDish(int id, CancellationToken cancellationToken)
        {
            var message = await _sideDishService.DeleteSideDishByRestaurantAsMessageAsync(id,cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

    }
}
