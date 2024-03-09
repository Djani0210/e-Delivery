using AutoMapper;
using e_Delivery.Database;
using e_Delivery.Entities;
using e_Delivery.Entities.Enums;
using e_Delivery.Model.Location;
using e_Delivery.Model.Order;
using e_Delivery.Model.Restaurant;
using e_Delivery.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Services
{
    public class OrderService : IOrderService
    {
        private readonly eDeliveryDBContext _dbContext;
        public IMapper Mapper { get; set; }
        public ILocationService _locationService { get; set; }
        public IAuthContext _authContext { get; set; }
        private UserManager<User> _userManager { get; set; }

        public OrderService(eDeliveryDBContext dbContext, IMapper mapper,
             ILocationService locationService, IAuthContext authContext, UserManager<User> userManager)
        {
            _dbContext = dbContext;
            Mapper = mapper;
            _locationService = locationService;
            _authContext = authContext;
            _userManager = userManager;
        }
        public async Task<Message> AssignDeliveryPersonToOrderAsMessageAsync(Guid orderId, Guid userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Message> CreateOrderAsMessageAsync(CreateOrderVM createOrderVM, CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await _authContext.GetLoggedUser();
                var locationCreateVM = new LocationCreateVM
                {
                    CityId = createOrderVM.CityId,
                    Latitude = createOrderVM.Latitude,
                    Longitude = createOrderVM.Longitude
                };
                var locationMessage = await _locationService.CreateLocationAsMessageAsync(locationCreateVM, cancellationToken);

                if (locationMessage == null || !locationMessage.IsValid)
                {

                    return new Message
                    {
                        IsValid = false,
                        Info = "Error during uploading a location!",
                        Status = ExceptionCode.BadRequest
                    };
                }

                var obj = Mapper.Map<Order>(createOrderVM);
                obj.CreatedByUserId = loggedUser.Id;
                obj.CreatedDate = DateTime.UtcNow;
                obj.OrderState = OrderState.Created;
                obj.LocationId = ((LocationGetVM)locationMessage.Data).Id;


                var orderItemsToAdd = new List<OrderItem>();
                foreach (var item in obj.OrderItems)
                {
                    var orderItem = Mapper.Map<OrderItem>(item);
                    orderItem.OrderId = obj.Id;
                    orderItem.FoodItem = await _dbContext.FoodItems.FindAsync(item.FoodItemId);

                    item.SideDishes = new List<SideDish>();


                    var sideDishIds = item.SideDishIds ?? new List<int>();
                    orderItem.SideDishes = await _dbContext.SideDishes
                        .Where(sd => sideDishIds.Contains(sd.Id))
                        .ToListAsync();

                    orderItemsToAdd.Add(orderItem);

                }
                obj.OrderItems.Clear();
                obj.OrderItems.AddRange(orderItemsToAdd);

                if (createOrderVM.PaymentMethod == Entities.Enums.PaymentMethod.CreditCard)
                    obj.IsPaid = true;
                else
                    obj.IsPaid = false;

                await _dbContext.AddAsync(obj);
                await _dbContext.SaveChangesAsync(cancellationToken);
                var orderGetVM = Mapper.Map<GetOrderVM>(obj);
                return new Message
                {
                    IsValid = true,
                    Info = "Successfully created the order",
                    Status = ExceptionCode.Success,
                    Data = orderGetVM
                };

            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException;
                while (innerException != null)
                {
                    innerException = innerException.InnerException;
                    Console.WriteLine(innerException);
                }
                return new Message
                {
                    IsValid = false,
                    Info = ex.Message,
                    Status = ExceptionCode.BadRequest
                };
            }
        }

        
        public async Task<Message> DeleteOrderAsMessageAsync(Guid orderId, CancellationToken cancellationToken)
        {
            try
            {
                var order = await _dbContext.Orders
                    .Include(o => o.OrderItems)
                    .Where(o => o.Id == orderId)
                    .FirstOrDefaultAsync(cancellationToken);

                if (order == null)
                {
                    return new Message
                    {
                        IsValid = false,
                        Status = ExceptionCode.NotFound,
                        Info = "Order not found."
                    };
                }

                // Remove associated order items
                _dbContext.OrderItems.RemoveRange(order.OrderItems);

                // Remove the order itself
                _dbContext.Orders.Remove(order);

                // Save changes to the database
                await _dbContext.SaveChangesAsync(cancellationToken);

                return new Message
                {
                    IsValid = true,
                    Status = ExceptionCode.Success,
                    Info = "Order and associated items deleted successfully."
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    IsValid = false,
                    Status = ExceptionCode.BadRequest,
                    Info = $"Error deleting order: {ex.Message}"
                };
            }
        }


        public async Task<Message> GetOrderByIdAsMessageAsync(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var order = await _dbContext.Orders
                    .Include(order => order.Location).ThenInclude(o => o.City)
                    .Include(o => o.OrderItems).ThenInclude(oi => oi.FoodItem).ThenInclude(fi => fi.FoodItemPictures)

                    .Include(o => o.OrderItems).ThenInclude(oi => oi.SideDishes)
                    .Where(order => order.Id == id).AsNoTracking()
                    .FirstOrDefaultAsync();

                var getOrderVM = Mapper.Map<GetOrderVM>(order);

                return new Message
                {
                    IsValid = true,
                    Status = ExceptionCode.Success,
                    Data = getOrderVM,
                    Info = "Successfully retrieved Order"
                };
            }
            catch (Exception ex)
            {

                return new Message
                {
                    IsValid = false,
                    Status = ExceptionCode.NotFound,
                    Info = ex.Message
                };
            }
        }

        public async Task<Message> GetOrderByRestaurantAsMessageAsync( CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await _authContext.GetLoggedUser();
                var order = await _dbContext.Orders
                    .Include(order => order.Location).ThenInclude(o => o.City)
                    .Include(o => o.OrderItems).ThenInclude(oi => oi.FoodItem).ThenInclude(fi => fi.FoodItemPictures)

                    .Include(o => o.OrderItems).ThenInclude(oi => oi.SideDishes)
                    .Where(order => order.RestaurantId == loggedUser.RestaurantId).AsNoTracking()
                    .ToListAsync();

                var getOrdersVM = Mapper.Map<List<GetOrderVM>>(order);

                return new Message
                {
                    IsValid = true,
                    Status = ExceptionCode.Success,
                    Data = getOrdersVM,
                    Info = "Successfully retrieved Orders"
                };
            }
            catch (Exception ex)
            {

                return new Message
                {
                    IsValid = false,
                    Status = ExceptionCode.NotFound,
                    Info = ex.Message
                };
            }
        }

        public async Task<Message> GetOrdersForCustomerAsMessageAsync(CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await _authContext.GetLoggedUser();
                var orders = await _dbContext.Orders
                    .Include(order => order.Location).ThenInclude(o => o.City)
                    .Include(o => o.OrderItems).ThenInclude(oi => oi.FoodItem).ThenInclude(fi => fi.FoodItemPictures)

                    .Include(o => o.OrderItems).ThenInclude(oi => oi.SideDishes)
                    .Where(order => order.CreatedByUserId == loggedUser.Id).AsNoTracking()
                    .ToListAsync();

                var getOrderVM = Mapper.Map<List<GetOrderVM>>(orders);

                return new Message
                {
                    IsValid = true,
                    Status = ExceptionCode.Success,
                    Data = getOrderVM,
                    Info = "Successfully retrieved Orders"
                };
            }
            catch (Exception ex)
            {

                return new Message
                {
                    IsValid = false,
                    Status = ExceptionCode.NotFound,
                    Info = ex.Message
                };
            }
        }

        public async Task<Message> GetOrdersForDeliveryPersonAsMessageAsync(CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await _authContext.GetLoggedUser();
                var orders = await _dbContext.Orders
                    .Include(order => order.Location).ThenInclude(o => o.City)
                    .Include(o => o.OrderItems).ThenInclude(oi => oi.FoodItem).ThenInclude(fi => fi.FoodItemPictures)

                    .Include(o => o.OrderItems).ThenInclude(oi => oi.SideDishes)
                    .Where(order => order.DeliveryPersonAssignedId == loggedUser.Id).AsNoTracking()
                    .ToListAsync();
                
                var getOrderVM = Mapper.Map<List<GetOrderVM>>(orders);

                return new Message
                {
                    IsValid = true,
                    Status = ExceptionCode.Success,
                    Data = getOrderVM,
                    Info = "Successfully retrieved Orders"
                };
            }
            catch (Exception ex)
            {

                return new Message
                {
                    IsValid = false,
                    Status = ExceptionCode.NotFound,
                    Info = ex.Message
                };
            }
        }

        public async Task<Message> UpdateOrderAsMessageAsync(Guid id, UpdateOrderVM updateOrderVM, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
