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
        [HttpPut("remove-Employee"), Authorize()]
        public async Task<IActionResult> RemoveEmployee(Guid id, CancellationToken cancellationToken)
        {
            var message = await _restaurantService.RemoveEmployeeFromRestaurantAsMessageAsync(id, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpGet("get-Restaurants"), Authorize()]
        public async Task<IActionResult> GetRestaurants(int id, CancellationToken cancellationToken, string? name, int? categoryId)
        {
            var message= await _restaurantService.GetRestaurantsAsMessage(id, cancellationToken,name, categoryId);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpGet("get-Restaurants-For-Admin"), Authorize(Roles ="Admin")]
        public async Task<IActionResult> GetRestaurantsForAdmin(CancellationToken cancellationToken, int? cityId, string? name, int items_per_page = 10, int pageNumber = 1)
        {
            var message = await _restaurantService.GetRestaurantsForAdminAsMessage(cancellationToken,cityId,name,items_per_page,pageNumber);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpGet("get-Restaurant-Employees"), Authorize(Roles="Desktop")]
        public async Task<IActionResult> GetRestaurantEmployees(CancellationToken cancellationToken, int items_per_page = 3, int pageNumber = 1, bool? isAvailable = null, string? username = null)
        {
            var message = await _restaurantService.GetRestaurantEmployeesAsMessageAsync(cancellationToken,items_per_page,pageNumber,isAvailable,username);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpGet("get-RestaurantById"), Authorize()]
        public async Task<IActionResult> GetRestaurantById(int id, CancellationToken cancellationToken)
        {
            var message = await _restaurantService.GetRestaurantByIdAsMessage(id,cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }
        [HttpDelete("delete-Restaurant"), Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteRestaurant(int id, CancellationToken cancellationToken)
        {
            var message = await _restaurantService.DeleteRestaurantAndRelatedEntitiesAsync(id,cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpGet("get-recommended-restaurants"), Authorize()]
        public async Task<IActionResult> GetRecommendedRestaurants()
        {
            var message = await _restaurantService.GetRecommendedRestaurants();
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }




    }
}
