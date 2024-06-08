using e_Delivery.Entities;
using e_Delivery.Model.Chat;
using e_Delivery.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Hubs
{
    [Authorize]
    public class ChatHub : Hub
    {
        public async Task SendMessage(Chat chat)
        {
            await Clients.User(chat.UserToId.ToString()).SendAsync("ReceiveMessage", chat);
        }
    }

}
