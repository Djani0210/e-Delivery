using e_Delivery.Model.Category;
using e_Delivery.Model.City;
using e_Delivery.Services.Interfaces;
using e_Delivery.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace e_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost("add-category"), Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddCategory(CategoryCreateVM categoryCreateVM, CancellationToken cancellationToken)
        {
            var message = await _categoryService.CreateCategoryAsMessageAsync(categoryCreateVM, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }
        [HttpGet("get-categories-for-admin"), Authorize()]
        public async Task<IActionResult> GetCategories(CancellationToken cancellationToken, string? name, int items_per_page = 10, int pageNumber = 1)
        {
            var message= await _categoryService.GetCategoriesAsMessageAsync(cancellationToken,name,items_per_page,pageNumber);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }
        [HttpGet("get-categories"), Authorize()]
        public async Task<IActionResult> GetCategoriesUnPaged(CancellationToken cancellationToken)
        {
            var message = await _categoryService.GetCategoriesUnPagedAsync(cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }
        [HttpGet("get-category-by-id"), Authorize()]
        public async Task<IActionResult> GetCategoryById(int id,CancellationToken cancellationToken)
        {
            var message = await _categoryService.GetCategoryByIdAsMessageAsync(id,cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpGet("get-categories-with-foodItems"), Authorize()]
        public async Task<IActionResult> GetCategoriesWithFoodItems(int restaurantId, CancellationToken cancellationToken)
        {
            var message = await _categoryService.GetCategoriesWithFoodItemsForRestaurantAsMessageAsync(restaurantId,cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }
        [HttpPut("update-category"), Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateCity(int id, categoryUpdateVM categoryVM, CancellationToken cancellationToken)
        {
            var message = await _categoryService.UpdateCategoryAsMessageAsync(id, categoryVM, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }
    }
}
