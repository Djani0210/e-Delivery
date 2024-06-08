using e_Delivery.Services.Interfaces;
using e_Delivery.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace e_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NotificationController:ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet("get-notifications"), Authorize()]
        public async Task<IActionResult> GetCategories(CancellationToken cancellationToken)
        {
            var message = await _notificationService.GetNotifications(cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpPatch("delete-notification"), Authorize()]
        public async Task<IActionResult> DeleteNotification(int id, CancellationToken cancellationToken)
        {
            var message = await _notificationService.SoftDeleteNotificaton(id,cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpDelete("delete-all-notifications"), Authorize()]
        public async Task<IActionResult> DeleteAllNotification(CancellationToken cancellationToken)
        {
            var message = await _notificationService.RemoveAllNotifications(cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }
    }
}
