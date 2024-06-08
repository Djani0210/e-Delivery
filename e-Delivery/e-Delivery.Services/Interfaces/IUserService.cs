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
        Task<Message> UpdateDeliveryPersonAsync(DeliveryPersonUpdateVM deliveryPersonUpdateVM, CancellationToken cancellationToken);
        Task<Message> GetUsersAsMessageAsync(CancellationToken cancellationToken);
        Task<Message> ForgotPasswordAsMessageAsync(VerificationCreateVM verificationCreateDto, CancellationToken cancellationToken);
        Task<Message> CheckCodeAsMessageAsync(VerificationCodeVM verificationCodeDto, CancellationToken cancellationToken);
        Task<Message> NewPasswordAsMessageAsync(NewPasswordVM newPasswordDto, CancellationToken cancellationToken);
        Task<Message> GetUserFromEmailAsMessageAsync(string email, CancellationToken cancellationToken);
        Task<Message> GetAdminAsMessageAsync(CancellationToken cancellationToken);
        Task<Message> GetLoggedCustomerAsMessageAsync(CancellationToken cancellationToken); 
        Task<Message> GetLoggedDeliveryPersonAsMessageAsync(CancellationToken cancellationToken);
        Task<Message> ConfirmApplicationAsync(Guid deliveryPersonId, int restaurantId);
        Task<Message> ApplyToRestaurantAsync(int restaurantId, CancellationToken cancellationToken);
    }
}
