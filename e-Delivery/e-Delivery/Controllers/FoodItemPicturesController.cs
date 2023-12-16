using e_Delivery.Database;
using e_Delivery.Model.FoodItem;
using e_Delivery.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace e_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Desktop")]
    public class FoodItemPicturesController : ControllerBase
    {
        private readonly eDeliveryDBContext _dbContext;
        private IFoodItemPicturesService _foodItemPictureService;
        public FoodItemPicturesController(eDeliveryDBContext dbContext, IFoodItemPicturesService foodItemPictureService)
        {
            _dbContext = dbContext;
            _foodItemPictureService = foodItemPictureService;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetAll(int id)
        {
            var message = await _foodItemPictureService.GetAllAsMessageAsync(id);
            if (!message.IsValid)
                return BadRequest(message);

            return Ok(message);
        }

        [HttpPost("{id}")]
        public async Task<ActionResult> AddProductPicture(int id, [FromForm] FoodItemPictureAddVM x)
        {
            var message = await _foodItemPictureService.CreateAsMessageAsync(id, x);
            if (message.IsValid)
                return Ok(message);

            return BadRequest(message.Info);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var message = await _foodItemPictureService.DeleteAsMessageAsync(id);
            if (!message.IsValid)
                return BadRequest(message);

            return Ok(message);
        }
    }
}
