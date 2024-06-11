using e_Delivery.Database;

using e_Delivery.Entities;
using e_Delivery.Model.City;
using e_Delivery.Model.FoodItem;
using e_Delivery.Model.SideDish;
using e_Delivery.Services.Interfaces;
using FluentValidation.Internal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FoodItemController : ControllerBase
    {
        private readonly IFoodItemService _foodItemService;
        private readonly eDeliveryDBContext _dbContext;
        public IAuthContext _authContext { get; set; }
        public FoodItemController(eDeliveryDBContext dbContext, IFoodItemService foodItemService,IAuthContext authContext)
        {
            _foodItemService = foodItemService;
            _dbContext = dbContext;
            _authContext = authContext;
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
        [HttpGet("get-Most-Frequent"), Authorize(Roles = "Desktop")]
        public async Task<ActionResult<FoodItem>> GetMostFrequentlyOrderedFoodItem()
        {
            var loggedUser = await _authContext.GetLoggedUser();
            var restaurantId = loggedUser.RestaurantId;

            var mostFrequentItem = await _dbContext.OrderItems
                .Where(oi => oi.FoodItem.RestaurantId == restaurantId)
                .Include(oi => oi.FoodItem)
                .GroupBy(oi => oi.FoodItemId)
                .OrderByDescending(g => g.Count())
                .Select(g => g.First().FoodItem)
                .FirstOrDefaultAsync();

            if (mostFrequentItem == null)
            {
                return NotFound(new { message = "No items have been ordered yet" });
            }

            return Ok(mostFrequentItem);
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
        public async Task<IActionResult> GetFoodItems(CancellationToken cancellationToken, string? categoryName = null, int items_per_page = 4, int pageNumber = 1, bool? isAvailable = null, string? itemName = null)
        {
            var message= await _foodItemService.GetFoodItemsAsMessageAsync(cancellationToken,categoryName,items_per_page,pageNumber,isAvailable,itemName);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpGet("get-FoodItemById"), Authorize()]
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

        [HttpGet("get-by-name{id}"),Authorize()]
        public async Task<ActionResult<string>> GetFoodItemNameById(int id)
        {
            try
            {
                var foodItemName = await _foodItemService.GetFoodItemNameById(id);
                if (string.IsNullOrEmpty(foodItemName))
                {
                    return NotFound("Food item not found.");
                }
                return Ok(foodItemName);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
