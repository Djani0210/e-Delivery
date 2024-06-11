using e_Delivery.Entities;
using e_Delivery.Model.Auth;
using e_Delivery.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Delivery.Services.JwtConfiguration;
using Microsoft.AspNetCore.Identity;
using e_Delivery.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using e_Delivery.Entities.Enums;

namespace e_Delivery.Services.Services
{
    public class AuthService : IAuthService
    {
        private JwtConfiguration.JwtConfiguration _jwtConfiguration { get; set; }
        private UserManager<User> _userManager { get; set; }
        private SignInManager<User> _signInManager { get; set; }
        private eDeliveryDBContext _dbContext { get; set; }
        private IAuthContext _authContext { get; set; }

        public AuthService(JwtConfiguration.JwtConfiguration jwtConfiguration,
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            eDeliveryDBContext dbContext, IAuthContext authContext)
        {
            _jwtConfiguration = jwtConfiguration;
            _userManager = userManager;
            _signInManager = signInManager;
            _dbContext = dbContext;
            _authContext = authContext;
        }

        public async Task<Message> Login(LoginVM loginVM, CancellationToken cancellationToken)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.UserName == loginVM.Username, cancellationToken);
            if (user == null)
            {
                return new Message
                {
                    Info = "Forbidden",
                    IsValid = false,
                    Status = ExceptionCode.Forbidden
                };
            }

            var userSignInResult = await _userManager.CheckPasswordAsync(user, loginVM.Password);

            if (userSignInResult)
            {
                var roles = await _userManager.GetRolesAsync(user);

                (string accessToken, long expiresIn) = GenerateJwt(user, roles);

                var refreshToken = SetRefreshToken(user);
                await _dbContext.SaveChangesAsync();

                var session = await GetSession(user.Id, accessToken, expiresIn, cancellationToken);

                return new Message
                {
                    Info = "Success",
                    IsValid = true,
                    Status = ExceptionCode.Success,
                    Data = (session, refreshToken)
                };
            }

            return new Message
            {
                Info = "Forbidden",
                IsValid = false,
                Status = ExceptionCode.Forbidden
            };
        }

        private (string Token, long ExpiresIn) GenerateJwt(User user, IList<string> roles)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };

            // Adding role claims. 
            var roleClaims = roles.Select(x => new Claim(ClaimTypes.Role, x));
            claims.AddRange(roleClaims);



            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfiguration.Secret));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.UtcNow.AddMinutes(Convert.ToDouble(_jwtConfiguration.ExpirationAccessTokenInMinutes));

            var token = new JwtSecurityToken(
                issuer: _jwtConfiguration.Issuer,
                audience: _jwtConfiguration.Issuer,
                (IEnumerable<System.Security.Claims.Claim>)claims,
                expires: expires,
                signingCredentials: creds
            );

            return (new JwtSecurityTokenHandler().WriteToken(token), new DateTimeOffset(expires).ToUnixTimeSeconds());
        }
        private string SetRefreshToken(User user)
        {
            user.RefreshToken = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            user.RefreshTokenExpireDate = DateTime.UtcNow.AddMinutes(_jwtConfiguration.ExpirationRefreshTokenInMinutes);
            return user.RefreshToken;
        }
        private async Task<SessionVM> GetSession(Guid userId, string accessToken, long accessTokenExpiration, CancellationToken cancellationToken)
        {
            var websiteUser = await _dbContext.Users
                .Select(x => new
                {
                    UserId = x.Id,
                    x.UserName,
                    x.FirstName,
                    x.LastName,
                    RestaurantId = x.RestaurantId,
                    CityId = x.CityId,
                    PhoneNumber = x.PhoneNumber,
                    Email = x.Email,
                    
                })
                .FirstOrDefaultAsync(x => x.UserId == userId, cancellationToken);

            var roles = await _dbContext.UserRoles.Where(x => x.UserId == userId).Select(x => x.RoleId).ToListAsync(cancellationToken);
            List<string> stringRoles = await _dbContext.Roles.Where(x => roles.Contains(x.Id)).Select(x => x.Name).ToListAsync(cancellationToken);

            var session = new SessionVM()
            {
                UserId = userId,
                Username = websiteUser.UserName,
                FirstName = websiteUser?.FirstName,
                LastName = websiteUser?.LastName,
                Token = accessToken,
                TokenExpireDate = accessTokenExpiration,
                RestaurantId = websiteUser.RestaurantId,
                CityId = websiteUser.CityId,
                PhoneNumber = websiteUser.PhoneNumber,
                Email = websiteUser.Email,
               
                Roles = stringRoles,

            };

            return session;
        }
        public async Task<Message> LogoutAsync(User user)
        {
            await _signInManager.SignOutAsync();

            user.RefreshToken = null;
            user.RefreshTokenExpireDate = DateTime.MinValue;
            await _dbContext.SaveChangesAsync(CancellationToken.None);

            return new Message
            {
                Info = "Success",
                IsValid = true,
                Status = ExceptionCode.Success,
            };
        }

        public async Task<Message> RefreshToken(string refreshToken, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(refreshToken))
            {
                return new Message
                {
                    Info = "Forbidden",
                    IsValid = false,
                    Status = ExceptionCode.Forbidden
                };
            }

            var user = await _userManager.Users.SingleOrDefaultAsync(u => u.RefreshToken == refreshToken, cancellationToken);
            if (user is null)
            {
                return new Message
                {
                    Info = "Forbidden",
                    IsValid = false,
                    Status = ExceptionCode.Forbidden
                };
            }
            else if (user.RefreshTokenExpireDate <= DateTime.UtcNow)
            {
                user.RefreshToken = null;
                user.RefreshTokenExpireDate = DateTime.MinValue;
                await _dbContext.SaveChangesAsync(CancellationToken.None);

                return new Message
                {
                    Info = "Forbidden",
                    IsValid = false,
                    Status = ExceptionCode.Forbidden
                };
            }

            var roles = await _userManager.GetRolesAsync(user);

            //var permissions = await GetPermissionsByRoles(roles, cancellationToken);

            (string accessToken, long expiresIn) = GenerateJwt(user, roles);

            var session = await GetSession(user.Id, accessToken, expiresIn, cancellationToken);

            return new Message
            {
                Info = "Success",
                IsValid = true,
                Status = ExceptionCode.Success,
                Data = session
            };
        }
    }
}
