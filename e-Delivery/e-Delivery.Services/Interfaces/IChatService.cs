using e_Delivery.Entities;
using e_Delivery.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Interfaces
{
    public interface IChatService
    {
        Task<Message> SendMessage(Guid userToId, string content);
        Task<Message> GetChatHistory(Guid userToId);
        Task<Message> DeleteMessage(Guid chatId);
        Task<Message> GetConnectedDeliveryPersons();
        Task<Message> GetConnectedCustomers();
       

    }
}
