using e_Delivery.Model.City;
using e_Delivery.Model.Review;
using e_Delivery.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace e_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;
        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpPost("add-Review"), Authorize(Roles = "MobileClient")]
        public async Task<IActionResult> AddReview(CreateOrUpdateReviewVM createOrUpdateReviewVM, CancellationToken cancellationToken)
        {
            var message = await _reviewService.CreateOrUpdateReviewAsMessageAsync(createOrUpdateReviewVM, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }
        [HttpDelete("delete-Review"), Authorize(Roles = "MobileClient")]
        public async Task<IActionResult> DeleteReview(int id, CancellationToken cancellationToken)
        {
            var message = await _reviewService.DeleteReviewAsMessageAsync(id, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }
        [HttpGet("get-Review-Score-For-Restaurant"),Authorize(Roles ="Desktop")]
        public async Task<IActionResult> GetReviewScoreForRestaurant(CancellationToken cancellationToken)
        {
            try
            {
                var score = await _reviewService.GetReviewScoreForRestaurantAsync(cancellationToken);

                if (score.HasValue)
                {    
                    return Ok(score.Value);
                }
                else
                {
                    return NotFound("No reviews found for the restaurant.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }

        }
    }
}
