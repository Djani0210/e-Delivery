using e_Delivery.Entities;
using e_Delivery.Model.Auth;
using e_Delivery.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Services
{
    public class AuthContextService : IAuthContext
    {
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuthContextService(UserManager<User> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<GetLoggedUserVM> GetLoggedUser()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (userId == null)
            {
                throw new ArgumentException("Unauthorized");
            }
            var user = await _userManager.FindByIdAsync(userId);

            return new GetLoggedUserVM
            {
                Id = Guid.Parse(userId),
                FirstName = user.FirstName,
                LastName = user.LastName,
                CityId = user.CityId,
                RestaurantId = user.RestaurantId,
            };
        }
    }
}
