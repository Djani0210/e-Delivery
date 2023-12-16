using e_Delivery.Model.User;
using e_Delivery.Model.Verification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Interfaces
{
    public interface IUserService
    {
        Task<Message> CreateUserAsMessageAsync(UserCreateVM user, CancellationToken cancellationToken);
        Task<Message> UpdateUserAsMessageAsync(Guid Id, UserUpdateVM user, CancellationToken cancellationToken);
        Task<Message> GetUsersAsMessageAsync(CancellationToken cancellationToken);
        Task<Message> ForgotPasswordAsMessageAsync(VerificationCreateVM verificationCreateDto, CancellationToken cancellationToken);
        Task<Message> CheckCodeAsMessageAsync(VerificationCodeVM verificationCodeDto, CancellationToken cancellationToken);
        Task<Message> NewPasswordAsMessageAsync(NewPasswordVM newPasswordDto, CancellationToken cancellationToken);
    }
}
