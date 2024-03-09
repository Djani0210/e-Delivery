
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
        [HttpPut("update-user/{Id}"), Authorize()]
        public async Task<IActionResult> UpdateUserAsMessageAsync(Guid Id, UserUpdateVM user, CancellationToken cancellationToken)
        {
            var message = await _userService.UpdateUserAsMessageAsync(Id, user, cancellationToken);
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
    }
}
