using e_Delivery.Model.Chat;
using e_Delivery.Services;
using e_Delivery.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace e_Delivery.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ChatController : ControllerBase
    {
        private readonly IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }
        [HttpPost("send-message"), Authorize()]
        public async Task<IActionResult> SendMessage(SendMessageDto sendMessageDto)
        {
            var result = await _chatService.SendMessage(sendMessageDto.UserToId, sendMessageDto.Content );
            return Ok(result);
        }

        [HttpGet("chat-history/{userToId}"), Authorize()]
        public async Task<IActionResult> GetChatHistory(Guid userToId)
        {
            var result = await _chatService.GetChatHistory(userToId);
            if (!result.IsValid)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpDelete("delete-message/{chatId}"), Authorize()]
        public async Task<IActionResult> DeleteMessage(Guid chatId)
        {
            var result = await _chatService.DeleteMessage(chatId);
            if (!result.IsValid)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

       

        [HttpGet("connected-delivery-persons"), Authorize()]
        public async Task<IActionResult> GetConnectedDeliveryPersons()
        {
            var result = await _chatService.GetConnectedDeliveryPersons();
            if (!result.IsValid)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

       

        [HttpGet("connected-customers"), Authorize()]
        public async Task<IActionResult> GetConnectedCustomers()
        {
            var result = await _chatService.GetConnectedCustomers();
            if (!result.IsValid)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        
    }
}
