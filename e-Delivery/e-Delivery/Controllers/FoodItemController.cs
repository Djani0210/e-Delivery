using e_Delivery.Model.City;
using e_Delivery.Model.FoodItem;
using e_Delivery.Model.SideDish;
using e_Delivery.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace e_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FoodItemController : ControllerBase
    {
        private readonly IFoodItemService _foodItemService;
        public FoodItemController(IFoodItemService foodItemService)
        {
            _foodItemService = foodItemService;
        }

        [HttpPost("add-FoodItem"), Authorize(Roles = "Desktop")]
        public async Task<IActionResult> AddFoodItem(CreateFoodItemVM createFoodItemVM, CancellationToken cancellationToken)
        {
            var message = await _foodItemService.CreateFoodItemAsMessageAsync(createFoodItemVM, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }
        [HttpPatch("{foodItemId}/removesidedishes"), Authorize(Roles = "Desktop")]
        public async Task<IActionResult> RemoveSideDishesFromFoodItem(int foodItemId,[FromBody] List<int> sideDishIds)
        {
            var message = await _foodItemService.RemoveSideDishesFromFoodItemAsync(foodItemId, sideDishIds);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpPut("update-FoodItem"), Authorize(Roles = "Desktop")]
        public async Task<IActionResult> UpdateFoodItem(int id ,UpdateFoodItemVM updateFoodItemVM, CancellationToken cancellationToken)
        {
            var message = await _foodItemService.UpdateFoodItemAsMessageAsync(id, updateFoodItemVM, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpGet("get-FoodItems"), Authorize()]
        public async Task<IActionResult> GetFoodItems(CancellationToken cancellationToken)
        {
            var message= await _foodItemService.GetFoodItemsAsMessageAsync(cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpGet("get-FoodItemsById"), Authorize()]
        public async Task<IActionResult> GetFoodItemById(int id, CancellationToken cancellationToken)
        {
            var message = await _foodItemService.GetFoodItemByIdAsMessageAsync(id,cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }
        [HttpDelete("delete-FoodItem"), Authorize(Roles = "Desktop")]
        public async Task<IActionResult> DeleteFoodItem(int id, CancellationToken cancellationToken)
        {
            var message = await _foodItemService.DeleteFoodItemAsMessageAsync(id,cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

    }
}
