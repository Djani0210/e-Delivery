using AutoMapper;
using e_Delivery.Database;
using e_Delivery.Entities;
using e_Delivery.Entities.Enums;
using e_Delivery.Model.Chat;
using e_Delivery.Model.User;
using e_Delivery.Services.Hubs;
using e_Delivery.Services.Interfaces;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Delivery.Services.Services
{
    public class ChatService : IChatService
    {
        private readonly eDeliveryDBContext _dbContext;
        private readonly IHubContext<ChatHub> _hubContext;
        private readonly IAuthContext _authContext;
        private readonly IMapper _mapper;

        public ChatService(eDeliveryDBContext dbContext, IHubContext<ChatHub> hubContext, IAuthContext authContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _hubContext = hubContext;
            _authContext = authContext;
            _mapper = mapper;
        }
        public async Task<Message> GetConnectedDeliveryPersons()
        {
            try
            {
                var loggedUser = await _authContext.GetLoggedUser();

                var deliveryPersons = await _dbContext.Orders
                    .Where(o => o.CreatedByUserId == loggedUser.Id && o.DeliveryPersonAssignedId != null)
                    .Select(o => o.DeliveryPersonAssigned)
                    .Distinct()
                    .ToListAsync();

                var deliveryPersonVMs = _mapper.Map<List<DeliveryPersonGetVM>>(deliveryPersons);

                return new Message
                {
                    Status = ExceptionCode.Success,
                    Info = "Connected delivery persons retrieved successfully",
                    Data = deliveryPersonVMs,
                    IsValid = true
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    Status = ExceptionCode.BadRequest,
                    Info = $"Error retrieving connected delivery persons: {ex.Message}",
                    Data = null,
                    IsValid = false
                };
            }
        }
       

        public async Task<Message> GetConnectedCustomers()
        {
            try
            {
                var loggedUser = await _authContext.GetLoggedUser();

                var customers = await _dbContext.Orders
                    .Where(o => o.DeliveryPersonAssignedId == loggedUser.Id)
                    .Select(o => o.CreatedByUser)
                    .Distinct()
                    .ToListAsync();

                var customerVMs = _mapper.Map<List<CustomerGetVM>>(customers);

                return new Message
                {
                    Status = ExceptionCode.Success,
                    Info = "Connected customers retrieved successfully",
                    Data = customerVMs,
                    IsValid = true
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    Status = ExceptionCode.BadRequest,
                    Info = $"Error retrieving connected customers: {ex.Message}",
                    Data = null,
                    IsValid = false
                };
            }
        }

        



        public async Task<Message> SendMessage(Guid userToId, string content)
        {
            try
            {
                var userFrom = await _authContext.GetLoggedUser();
                Guid userFromId = userFrom.Id;

                var chat = new Chat
                {
                    Id = Guid.NewGuid(),
                    UserFromId = userFromId,
                    UserToId = userToId,
                    Content = content,
                    IsDeleted = false,
                    CreatedDate = DateTime.UtcNow
                };


                await _dbContext.Chats.AddAsync(chat);
                await _dbContext.SaveChangesAsync();

                await _hubContext.Clients.User(userToId.ToString()).SendAsync("ReceiveMessage", chat);
                return new Message
                {
                    Status = ExceptionCode.Success,
                    Info = "Message sent successfully",
                    Data = chat,
                    IsValid = true
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    Status = ExceptionCode.BadRequest,
                    Info = $"Error sending message: {ex.Message}",
                    Data = null,
                    IsValid = false
                };
            }
        }

        public async Task<Message> GetChatHistory(Guid userToId)
        {
            try
            {
                var userFrom = await _authContext.GetLoggedUser();
                Guid userFromId = userFrom.Id;

                var chats = await _dbContext.Chats
                    .Where(c => ((c.UserFromId == userFromId && c.UserToId == userToId) ||
                                 (c.UserFromId == userToId && c.UserToId == userFromId)) &&
                                 !c.IsDeleted) 
                    .OrderBy(c => c.CreatedDate)
                    .ToListAsync();

                var chatDtos = _mapper.Map<List<ChatDto>>(chats);

                return new Message
                {
                    Status = ExceptionCode.Success,
                    Info = "Chat history retrieved successfully",
                    Data = chatDtos,
                    IsValid = true
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    Status = ExceptionCode.BadRequest,
                    Info = $"Error retrieving chat history: {ex.Message}",
                    Data = null,
                    IsValid = false
                };
            }
        }

        public async Task<Message> DeleteMessage(Guid chatId)
        {
            try
            {
                var chat = await _dbContext.Chats.FindAsync(chatId);
                if (chat != null)
                {
                    chat.IsDeleted = true;
                    await _dbContext.SaveChangesAsync();

                    return new Message
                    {
                        Status = ExceptionCode.Success,
                        Info = "Message deleted successfully",
                        Data = null,
                        IsValid = true
                    };
                }
                else
                {
                    return new Message
                    {
                        Status = ExceptionCode.NotFound,
                        Info = "Message not found",
                        Data = null,
                        IsValid = false
                    };
                }
            }
            catch (Exception ex)
            {
                return new Message
                {
                    Status = ExceptionCode.BadRequest,
                    Info = $"Error deleting message: {ex.Message}",
                    Data = null,
                    IsValid = false
                };
            }
        }

        

        
    }
}
