
using e_Delivery.Model;
using e_Delivery.Services.Interfaces;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace e_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FileController : ControllerBase
    {

        private readonly IFileService _fileService;

        public FileController(IFileService _fileService)
        {
            this._fileService = _fileService;
        }

        [HttpPost("upload-restaurant-logo"), Authorize(Roles ="Desktop")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> UploadAndSetRestaurantLogo([FromForm] FileUploadVM fileUploadDto, CancellationToken cancellationToken)
        {
            var message = await _fileService.UploadAndSetRestaurantLogoAsync(fileUploadDto, cancellationToken);
            if (!message.IsValid)
                return BadRequest(message);
            return Ok(message);
        }

        [HttpDelete("delete-restaurant-logo"), Authorize(Roles ="Desktop")]
        public async Task<IActionResult> DeleteRestaurantLogo(CancellationToken cancellationToken)
        {
            var message = await _fileService.DeleteRestaurantLogoAsync(cancellationToken);
            if (!message.IsValid)
                return BadRequest(message);
            return Ok(message);
        }
        [HttpPut("update-restaurant-logo"), Authorize(Roles ="Desktop")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> UpdateRestaurantLogo([FromForm] FileUploadVM fileUploadDto, CancellationToken cancellationToken)
        {
            var message = await _fileService.UpdateRestaurantLogoAsync(fileUploadDto, cancellationToken);
            if (!message.IsValid)
                return BadRequest(message);
            return Ok(message);
        }



        [HttpPost("upload-image"), Authorize()]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> UploadFileAsMessage([FromForm]FileUploadVM fileUploadDto, CancellationToken cancellationToken)
        {
            var message = await _fileService.UploadImageAsMessageAsync(fileUploadDto, cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }
        [HttpPost("upload-profile-image"), Authorize()]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> UploadProfileFileAsMessage([FromForm]FileUploadVM fileUploadDto, CancellationToken cancellationToken)
        {
            var message = await _fileService.ChangeMyProfilePictureAsMessageAsync(fileUploadDto, cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }
        [HttpGet("get-images"), Authorize()]
        public async Task<IActionResult> GetFilesByRestaurant(CancellationToken cancellationToken)
        {
            var message = await _fileService.GetImagesByRestaurantAsMessageAsync(cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }
        [HttpGet("get-profile-image"), Authorize()]
        public async Task<IActionResult> GetProfileImageAsMessageAsync(CancellationToken cancellationToken)
        {
            var message = await _fileService.GetProfilePictureAsMessageAsync(cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }
        [HttpGet("get-images/{restaurantId}"), Authorize()]
        public async Task<IActionResult> GetFilesByRestaurantId(int restaurantId, CancellationToken cancellationToken)
        {
            var message = await _fileService.GetImagesByRestaurantIdAsMessageAsync(restaurantId, cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }

        [HttpGet("get-Profile-Pic-By-Id/{id}"), Authorize()]
        public async Task<IActionResult> GetProfileImageByUserId(Guid id, CancellationToken cancellationToken)
        {
            var message = await _fileService.GetProfileImageByUserId(id, cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }
        [HttpDelete("delete-image/{Id}"), Authorize()]
        public async Task<IActionResult> DeleteImageAsMessageAsync(int Id, CancellationToken cancellationToken)
        {
            var message = await _fileService.DeleteImageByRestaurantAsMessageAsync(Id, cancellationToken);
            if (message.IsValid == false)
                return BadRequest(message);
            return Ok(message);
        }
    }
}
