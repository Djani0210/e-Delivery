using AutoMapper;
using e_Delivery.Database;
using e_Delivery.Model.Category;
using e_Delivery.Model.Notification;
using e_Delivery.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Services
{
    public class NotificationService : INotificationService
    {
        public readonly eDeliveryDBContext _dbContext;
        public IMapper Mapper { get; set; }
        private IAuthContext authContext { get; set; }

        public NotificationService(eDeliveryDBContext dbContext, IMapper mapper, IAuthContext AuthContext)
        {
            _dbContext = dbContext;
            Mapper = mapper;
            authContext = AuthContext;
        }

        public async Task<Message> GetNotifications(CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await authContext.GetLoggedUser();
                var notifications = await _dbContext.Notifications
                    .Where(n => n.SentToUserId == loggedUser.Id && !n.IsDeleted).OrderByDescending(n=>n.CreatedDate)
                    .ToListAsync(cancellationToken);

                

                var obj = Mapper.Map<List<GetNotificationVM>>(notifications);
               
                return new Message
                {
                    Info = notifications.Any() ? "Fetched notifications" : "No notifications found",
                    IsValid = true,
                    Data = obj,
                    Status = Entities.Enums.ExceptionCode.Success
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    Info = ex.Message,
                    IsValid = false,
                    Status = Entities.Enums.ExceptionCode.BadRequest
                };
            }
        }

        public async Task<Message> SoftDeleteNotificaton(int id, CancellationToken cancellationToken)
        {
            try
            {
                var notification = await _dbContext.Notifications.FindAsync(id);
                if (notification == null)
                {
                    return new Message
                    {
                        Info = "Notification not found",
                        IsValid = false,
                        Status = Entities.Enums.ExceptionCode.NotFound
                    };
                }
                notification.IsDeleted = true;
                await _dbContext.SaveChangesAsync(cancellationToken);
                return new Message
                {
                    Info = "Successfully deleted notification",
                    IsValid = true,
                    Data = null,
                    Status = Entities.Enums.ExceptionCode.Success
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    Info = ex.Message,
                    IsValid = false,
                    Status = Entities.Enums.ExceptionCode.BadRequest
                };
            }
        }

        public async Task<Message> RemoveAllNotifications(CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await authContext.GetLoggedUser();
                var notifications = await _dbContext.Notifications
                    .Where(n => n.SentToUserId == loggedUser.Id)
                    .ToListAsync(cancellationToken);

                if (!notifications.Any())
                {
                    return new Message
                    {
                        Info = "No notifications found",
                        IsValid = true,
                        Data = null,
                        Status = Entities.Enums.ExceptionCode.Success
                    };
                }

                _dbContext.Notifications.RemoveRange(notifications);
                await _dbContext.SaveChangesAsync(cancellationToken);
                return new Message
                {
                    Info = "Successfully deleted all notifications",
                    IsValid = true,
                    Data = null,
                    Status = Entities.Enums.ExceptionCode.Success
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    Info = ex.Message,
                    IsValid = false,
                    Status = Entities.Enums.ExceptionCode.BadRequest
                };
            }
        }
    }
}
