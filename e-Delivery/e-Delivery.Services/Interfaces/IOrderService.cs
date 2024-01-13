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
        Task<Message> GetOrdersForCustomerAsMessageAsync(CancellationToken cancellationToken);
        Task<Message> GetOrdersForDeliveryPersonAsMessageAsync(CancellationToken cancellationToken);

        Task<Message> AssignDeliveryPersonToOrderAsMessageAsync(Guid orderId,Guid userId, CancellationToken cancellationToken);
        Task<Message> DeleteOrderAsMessageAsync(Guid orderId, CancellationToken cancellationToken);
        Task<Message> UpdateOrderAsMessageAsync(Guid id, UpdateOrderVM updateOrderVM, CancellationToken cancellationToken);

    }
}
