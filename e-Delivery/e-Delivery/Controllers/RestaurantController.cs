using e_Delivery.Model.City;
using e_Delivery.Model.FoodItem;
using e_Delivery.Model.Restaurant;
using e_Delivery.Model.SideDish;
using e_Delivery.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace e_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;
        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        [HttpPost("add-Restaurant"), Authorize(Roles = "Desktop")]
        public async Task<IActionResult> AddRestaurant(RestaurantCreateVM restaurantCreateVM, CancellationToken cancellationToken)
        {
            var message = await _restaurantService.CreateRestaurantAsMessage(restaurantCreateVM, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }
        //[HttpPatch("{foodItemId}/removesidedishes"), Authorize(Roles = "Desktop")]
        //public async Task<IActionResult> RemoveSideDishesFromFoodItem(int foodItemId,[FromBody] List<int> sideDishIds)
        //{
        //    var message = await _foodItemService.RemoveSideDishesFromFoodItemAsync(foodItemId, sideDishIds);
        //    if (!message.IsValid)
        //    {
        //        return BadRequest(message);
        //    }
        //    return Ok(message);
        //}

        [HttpPut("update-Restaurant"), Authorize(Roles = "Desktop")]
        public async Task<IActionResult> UpdateRestaurant(int id ,RestaurantUpdateVM restaurantUpdateVM, CancellationToken cancellationToken)
        {
            var message = await _restaurantService.UpdateRestaurantAsMessage(id, restaurantUpdateVM, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpGet("get-Restaurants"), Authorize()]
        public async Task<IActionResult> GetRestaurants(int id, CancellationToken cancellationToken)
        {
            var message= await _restaurantService.GetRestaurantsAsMessage(id, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpGet("get-RestauantById"), Authorize()]
        public async Task<IActionResult> GetRestaurantById(int id, CancellationToken cancellationToken)
        {
            var message = await _restaurantService.GetRestaurantByIdAsMessage(id,cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }
        [HttpDelete("delete-Restaurant"), Authorize(Roles = "Desktop")]
        public async Task<IActionResult> DeleteRestaurant(int id, CancellationToken cancellationToken)
        {
            var message = await _restaurantService.DeleteRestaurantAndRelatedEntitiesAsync(id,cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

    }
}
