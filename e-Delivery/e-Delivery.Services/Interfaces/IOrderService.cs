using e_Delivery.Entities.Enums;
using e_Delivery.Model.Location;
using e_Delivery.Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Interfaces
{
    public interface IOrderService
    {
        Task<Message> CreateOrderAsMessageAsync(CreateOrderVM createOrderVM, CancellationToken cancellationToken);
        Task<Message> GetOrderByIdAsMessageAsync(Guid id, CancellationToken cancellationToken);
        Task<Message> GetOrderByRestaurantAsMessageAsync(CancellationToken cancellationToken, int items_per_page = 4, int pageNumber = 1,DateTime? startDate =null,
        DateTime? endDate = null, int? orderState = null);
        Task<Message> GetOrdersForCustomerAsMessageAsync(GetOrdersFilterDto? filterDto,CancellationToken cancellationToken);
        Task<Message> GetOrdersForDeliveryPersonAsMessageAsync(GetOrdersFilterDto? filterDto,CancellationToken cancellationToken);
        Task<Message> UpdateOrderStateAsMessageAsync(Guid orderId, OrderState newState, CancellationToken cancellationToken);
        Task<Message> AssignDeliveryPersonToOrderAsMessageAsync(Guid orderId,Guid userId, CancellationToken cancellationToken);
        Task<Message> DeleteOrderAsMessageAsync(Guid orderId, CancellationToken cancellationToken);
       


    }
}
