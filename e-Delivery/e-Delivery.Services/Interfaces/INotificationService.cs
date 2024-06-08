using e_Delivery.Model.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Interfaces
{
    public interface INotificationService
    {
        Task<Message> GetNotifications( CancellationToken cancellationToken);
        Task<Message> SoftDeleteNotificaton (int id, CancellationToken cancellationToken);

        Task<Message> RemoveAllNotifications (CancellationToken cancellationToken);
    }
}
