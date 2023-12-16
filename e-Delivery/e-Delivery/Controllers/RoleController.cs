using e_Delivery.Model.Role;
using e_Delivery.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace e_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService _roleService)
        {
            this._roleService = _roleService;
        }

        [HttpPost("create-role")]
        public async Task<IActionResult> CreateRoleAsMessageAsync(RoleCreateVM roleCreateVM, CancellationToken cancellationToken)
        {
            var message = await _roleService.CreateRoleAsMessageAsync(roleCreateVM, cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }
        [HttpPut("update-role")]
        public async Task<IActionResult> UpdateRoleAsMessageAsync(RoleUpdateVM roleUpdateVM, CancellationToken cancellationToken)
        {
            var message = await _roleService.UpdateRoleToUserAsMessageAsync(roleUpdateVM, cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }
        [AllowAnonymous]
        [HttpDelete("delete-role")]
        public async Task<IActionResult> DeleteRoleAsMessageAsync(Guid roleId, CancellationToken cancellationToken)
        {
            var message = await _roleService.DeleteRoleAsMessageAsync(roleId, cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }
        [HttpPost("add-role-to-user")]
        public async Task<IActionResult> AddRoleToUserAsMessageAsync(UserRoleVM userRoleVM, CancellationToken cancellationToken)
        {
            var message = await _roleService.AddRoleToUserAsMessageAsync(userRoleVM, cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }
        [HttpGet("get-roles")]
        [AllowAnonymous]
        public async Task<IActionResult> GetRolesAsMessageAsync(CancellationToken cancellationToken)
        {
            var message = await _roleService.GetRolesAsMessageAsync(cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }
    }
}

