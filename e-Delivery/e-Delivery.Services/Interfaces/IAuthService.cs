using e_Delivery.Entities;
using e_Delivery.Model.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Interfaces
{
    public interface IAuthService
    {
        Task<Message> Login(LoginVM loginDto, CancellationToken cancellationToken);
        Task<Message> RefreshToken(string refreshToken, CancellationToken cancellationToken);
        Task<Message> LogoutAsync(User user);
    }
}
