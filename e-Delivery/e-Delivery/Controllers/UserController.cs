
using e_Delivery.Model.User;
using e_Delivery.Model.Verification;
using e_Delivery.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ITShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService _userService)
        {
            this._userService = _userService;
        }
        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> CreateUserAsMessageAsync(UserCreateVM userCreateVM, CancellationToken cancellationToken)
        {
            var message = await _userService.CreateUserAsMessageAsync(userCreateVM, cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }
        [HttpGet, Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetUsersAsMessageAsync(CancellationToken cancellationToken)
        {
            var message = await _userService.GetUsersAsMessageAsync(cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }
        

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassowrdAsMessageAsync(VerificationCreateVM verificationCreateDto, CancellationToken cancellationToken)
        {
            var message = await _userService.ForgotPasswordAsMessageAsync(verificationCreateDto, cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }
        [HttpPost("check-code")]
        public async Task<IActionResult> CheckCodeAsMessageAsync(VerificationCodeVM verificationCodeDto, CancellationToken cancellationToken)
        {
            var message = await _userService.CheckCodeAsMessageAsync(verificationCodeDto, cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }
        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePasswordAsMessageAsync(NewPasswordVM newPasswordDto, CancellationToken cancellationToken)
        {
            var message = await _userService.NewPasswordAsMessageAsync(newPasswordDto, cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }
        [HttpGet("get-user-from-email")]
        public async Task<IActionResult> GetUserFromEmailAsMessageAsync(string email, CancellationToken cancellationToken)
        {
            var message = await _userService.GetUserFromEmailAsMessageAsync(email, cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }

        [HttpGet("get-admin"), Authorize()]
        public async Task<IActionResult> GetAdminMessageAsync(CancellationToken cancellationToken)
        {
            var message = await _userService.GetAdminAsMessageAsync(cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }


        [HttpGet("get-logged-customer"), Authorize()]
        public async Task<IActionResult> GetLoggedCustomer(CancellationToken cancellationToken)
        {
            var message = await _userService.GetLoggedCustomerAsMessageAsync(cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }
        [HttpGet("get-logged-delivery-person"), Authorize()]
        public async Task<IActionResult> GetLoggedDeliveryPerson(CancellationToken cancellationToken)
        {
            var message = await _userService.GetLoggedDeliveryPersonAsMessageAsync(cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }

        [HttpPut("update-profile/{id}"), Authorize()]
        public async Task<IActionResult> UpdateProfile(Guid id, [FromBody] UserUpdateVM userUpdateVM, CancellationToken cancellationToken)
        {
            var result = await _userService.UpdateUserAsMessageAsync(id, userUpdateVM, cancellationToken);
            if (result.IsValid)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update-delivery-person-availability"),Authorize()]
        public async Task<IActionResult> UpdateDeliveryPersonAvailability( [FromBody] DeliveryPersonUpdateVM vm, CancellationToken cancellationToken)
        {
            var result = await _userService.UpdateDeliveryPersonAsync( vm, cancellationToken);
            if (result.IsValid)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("confirm")]
        public async Task<IActionResult> ConfirmApplication(Guid deliveryPersonId, int restaurantId)
        {
            var message = await _userService.ConfirmApplicationAsync(deliveryPersonId, restaurantId);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }
        [HttpPost("apply/{restaurantId}")]
        public async Task<IActionResult> ApplyToRestaurant(int restaurantId, CancellationToken cancellationToken)
        {
            var message = await _userService.ApplyToRestaurantAsync(restaurantId, cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }

    }
}
