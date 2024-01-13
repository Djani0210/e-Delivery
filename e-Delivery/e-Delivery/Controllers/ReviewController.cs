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
            var message= await _reviewService.DeleteReviewAsMessageAsync(id,cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }
    }
}
