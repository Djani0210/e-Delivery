using AutoMapper;
using e_Delivery.Database;
using e_Delivery.Entities;
using e_Delivery.Entities.Enums;
using e_Delivery.Model.Location;
using e_Delivery.Model.Order;
using e_Delivery.Model.Restaurant;
using e_Delivery.Services.Hubs;
using e_Delivery.Services.Interfaces;
using e_Delivery.Services.PagedList;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
        public IServiceProvider _serviceProvider { get; set; }
        private readonly IHubContext<MyHub> _hubContext;


        public OrderService(eDeliveryDBContext dbContext, IMapper mapper,
             ILocationService locationService, IAuthContext authContext, UserManager<User> userManager, IServiceProvider serviceProvider, IHubContext<MyHub> hubContext)
        {
            _dbContext = dbContext;
            Mapper = mapper;
            _locationService = locationService;
            _authContext = authContext;
            _userManager = userManager;
            _serviceProvider = serviceProvider;
            _hubContext = hubContext;
        }
        public async Task<Message> AssignDeliveryPersonToOrderAsMessageAsync(Guid orderId, Guid userId, CancellationToken cancellationToken)
        {
           
            try
            {
                var loggedUser = await _authContext.GetLoggedUser();
                var order = await _dbContext.Orders.Where(o => o.Id == orderId).FirstOrDefaultAsync();
                var user = await _dbContext.Users.Where(u => u.Id == userId).FirstOrDefaultAsync();

                var restaurant = await _dbContext.Restaurants.Where(restaurant => restaurant.CreatedByUserId == loggedUser.Id).FirstOrDefaultAsync();

                if (user == null || order == null)
                {
                    return new Message
                    {
                        Info = "User or order is null",
                        IsValid = false,
                        Status = ExceptionCode.NotFound
                    };
                }

                order.DeliveryPersonAssignedId = userId;
                await UpdateOrderStateAsMessageAsync(order.Id, (OrderState)2, cancellationToken);

                if (order.DeliveryPersonAssignedId != null)
                {
                    try
                    {
                        await _hubContext.Clients.User(userId.ToString()).SendAsync("ReceiveNotification", "You have been assigned to a new order");

                        var notification = new Notification
                        {
                            Content = "You have been assigned to a new order",
                            CreatedDate = DateTime.Now,
                            IsDeleted = false,
                            SentByUserId = loggedUser.Id,
                            SentToUserId = userId,
                            RestaurantName = restaurant?.Name
                           
                        };
                        await _dbContext.Notifications.AddAsync(notification, cancellationToken);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error sending notification: " + ex.Message);
                    }
                }

                await _dbContext.SaveChangesAsync(cancellationToken);
                

                return new Message
                {
                    Data = null,
                    Info = "Successfully added employee to order",
                    Status = ExceptionCode.Success,
                    IsValid = true,
                };
            }
            catch (Exception ex)
            {
                
                return new Message
                {
                    Info = ex.Message,
                    IsValid = false,
                    Status = ExceptionCode.BadRequest
                };
            }
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
                obj.CreatedDate = DateTime.Now;
                obj.OrderState = OrderState.Created;
                obj.LocationId = ((LocationGetVM)locationMessage.Data).Id;

                var orderItemsToAdd = new List<OrderItem>();
                foreach (var item in obj.OrderItems)
                {
                    var orderItem = Mapper.Map<OrderItem>(item);
                    orderItem.OrderId = obj.Id;
                    orderItem.FoodItem = await _dbContext.FoodItems.FindAsync(item.FoodItemId);

                    var sideDishIds = item.SideDishIds ?? new List<int>();
                    orderItem.OrderItemSideDishes = new List<OrderItemSideDish>();

                    foreach (var sideDishId in sideDishIds)
                    {
                        var sideDish = await _dbContext.SideDishes.FindAsync(sideDishId);
                        if (sideDish != null)
                        {
                            var orderItemSideDish = new OrderItemSideDish
                            {
                                OrderItem = orderItem,
                                SideDish = sideDish
                            };
                            orderItem.OrderItemSideDishes.Add(orderItemSideDish);
                        }
                    }

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

               
                foreach (var orderItem in obj.OrderItems)
                {
                    orderItem.SideDishes = orderItem.OrderItemSideDishes.Select(ois => ois.SideDish).ToList();
                }

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
                    .Where(o => o.Id == orderId && !o.IsDeleted)
                    .FirstOrDefaultAsync(cancellationToken);

                if (order == null)
                {
                    return new Message
                    {
                        IsValid = false,
                        Status = ExceptionCode.NotFound,
                        Info = "Order not found or already deleted."
                    };
                }

               
                order.IsDeleted = true;

                

                await _dbContext.SaveChangesAsync(cancellationToken);

                return new Message
                {
                    IsValid = true,
                    Status = ExceptionCode.Success,
                    Info = "Order and associated items soft deleted successfully."
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
                var order = await _dbContext.Orders.Include(o => o.CreatedByUser).Include(o => o.DeliveryPersonAssigned).Include(o => o.Restaurant)
                    .Include(order => order.Location).ThenInclude(o => o.City)
                    .Include(o => o.OrderItems).ThenInclude(oi => oi.FoodItem).ThenInclude(fi => fi.FoodItemPictures)


                     .Include(o => o.OrderItems).ThenInclude(oi => oi.OrderItemSideDishes).ThenInclude(ois => ois.SideDish)
                    .Include(o => o.OrderItems).ThenInclude(oi => oi.FoodItem).ThenInclude(fi => fi.Category)
                    .Where(order => order.Id == id).AsNoTracking()
                    .FirstOrDefaultAsync();
                foreach (var orderItem in order.OrderItems)
                {
                    orderItem.SideDishes = orderItem.OrderItemSideDishes.Select(ois => ois.SideDish).ToList();
                }

                var getOrderVM = Mapper.Map<GetOrderVM>(order);
                getOrderVM.Address = order.Address;
                getOrderVM.DeliveryPersonId = order.DeliveryPersonAssignedId;
                getOrderVM.RestaurantName = order.Restaurant.Name;
                getOrderVM.CreatedByUserId = order.CreatedByUserId.ToString();
                if (order.DeliveryPersonAssigned != null)
                {
                    getOrderVM.DeliveryPersonAssigned = order.DeliveryPersonAssigned.FirstName + " " + order.DeliveryPersonAssigned.LastName;
                }
                else
                {
                    getOrderVM.DeliveryPersonAssigned = null;
                }
                getOrderVM.UserName = order.CreatedByUser?.UserName;
                getOrderVM.DeliveryCost = order.Restaurant.DeliveryCharge;

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

        public async Task<Message> GetOrderByRestaurantAsMessageAsync(CancellationToken cancellationToken, int items_per_page = 4, int pageNumber = 1, DateTime? startDate = null,
         DateTime? endDate = null, int? orderState = null)
        {
            try
            {
                var loggedUser = await _authContext.GetLoggedUser();
                var query = _dbContext.Orders
                    .Include(order => order.Location).ThenInclude(o => o.City)
                    .Include(o => o.OrderItems).ThenInclude(oi => oi.FoodItem).ThenInclude(fi => fi.FoodItemPictures)
                    .Include(o => o.OrderItems).ThenInclude(oi => oi.OrderItemSideDishes).ThenInclude(ois => ois.SideDish)
                    .Where(order => order.RestaurantId == loggedUser.RestaurantId && !order.IsDeleted)
                    .OrderByDescending(order => order.CreatedDate)
                    .AsQueryable();
                if (startDate.HasValue)
                {
                    query = query.Where(order => order.CreatedDate >= startDate.Value);
                }

                if (endDate.HasValue)
                {
                    query = query.Where(order => order.CreatedDate <= endDate.Value);
                }
                if (orderState.HasValue)
                {
                    query = query.Where(order => (int)order.OrderState == orderState.Value);
                }
                var pagedOrders = await PagedList<Order>.Create(query, pageNumber, items_per_page);

                foreach (var order in pagedOrders.DataItems)
                {
                    foreach (var orderItem in order.OrderItems)
                    {
                        orderItem.SideDishes = orderItem.OrderItemSideDishes.Select(ois => ois.SideDish).ToList();
                    }
                }

                var getOrdersVM = Mapper.Map<List<GetOrderVM>>(pagedOrders.DataItems);

                return new Message
                {
                    IsValid = true,
                    Status = ExceptionCode.Success,
                    Data = new { Orders = getOrdersVM, pagedOrders.TotalPages, pagedOrders.TotalCount },
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


        public async Task<Message> GetOrdersForCustomerAsMessageAsync(GetOrdersFilterDto? filterDto,CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await _authContext.GetLoggedUser();
                IQueryable<Order> orders =   _dbContext.Orders
                     .Include(order => order.Location).ThenInclude(o => o.City)
                     .Include(o => o.OrderItems).ThenInclude(oi => oi.FoodItem).ThenInclude(fi => fi.FoodItemPictures)

                     .Include(o => o.OrderItems).ThenInclude(oi => oi.OrderItemSideDishes).ThenInclude(ois => ois.SideDish)
                     .Where(order => order.CreatedByUserId == loggedUser.Id).OrderByDescending(o => o.CreatedDate);
                    
                    
                  


                if (filterDto.StartDate.HasValue && filterDto.EndDate.HasValue)
                {
                    orders = orders.Where(o => o.CreatedDate >= filterDto.StartDate.Value && o.CreatedDate <= filterDto.EndDate.Value);
                }

                if (filterDto.OrderState.HasValue)
                {
                    orders = orders.Where(o => o.OrderState == filterDto.OrderState.Value);
                }

              
                if (filterDto.SortBy == "totalPriceAsc")
                {
                    orders = orders.OrderBy(o => o.TotalCost);
                }
                else if (filterDto.SortBy == "totalPriceDesc")
                {
                    orders = orders.OrderByDescending(o => o.TotalCost);
                }

               
                var pagedOrders = await PagedList<Order>.Create(orders, filterDto.PageNumber ?? 1, filterDto.PageSize ?? 10);

                foreach (var order in pagedOrders.DataItems)
                {
                    foreach (var orderItem in order.OrderItems)
                    {
                        orderItem.SideDishes = orderItem.OrderItemSideDishes.Select(ois => ois.SideDish).ToList();
                    }
                }

                var getOrderVM = Mapper.Map<List<GetOrderVM>>(pagedOrders.DataItems);

                return new Message
                {
                    IsValid = true,
                    Status = ExceptionCode.Success,
                    Data = new
                    {
                        Orders = getOrderVM,
                        TotalCount = pagedOrders.TotalCount,
                        CurrentPage = pagedOrders.CurrentPage,
                        TotalPages = pagedOrders.TotalPages
                    },
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

        public async Task<Message> GetOrdersForDeliveryPersonAsMessageAsync(GetOrdersFilterDto? filterDto,CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await _authContext.GetLoggedUser();
                IQueryable<Order> orders = _dbContext.Orders
                    .Include(order => order.Location).ThenInclude(o => o.City)
                    .Include(o => o.OrderItems).ThenInclude(oi => oi.FoodItem).ThenInclude(fi => fi.FoodItemPictures)

                    .Include(o => o.OrderItems).ThenInclude(oi => oi.OrderItemSideDishes).ThenInclude(ois => ois.SideDish)
                    .Where(order => order.DeliveryPersonAssignedId == loggedUser.Id).OrderByDescending(o => o.CreatedDate);


                if (filterDto.StartDate.HasValue && filterDto.EndDate.HasValue)
                {
                    orders = orders.Where(o => o.CreatedDate >= filterDto.StartDate.Value && o.CreatedDate <= filterDto.EndDate.Value);
                }

                if (filterDto.OrderState.HasValue)
                {
                    orders = orders.Where(o => o.OrderState == filterDto.OrderState.Value);
                }


                if (filterDto.SortBy == "totalPriceAsc")
                {
                    orders = orders.OrderBy(o => o.TotalCost);
                }
                else if (filterDto.SortBy == "totalPriceDesc")
                {
                    orders = orders.OrderByDescending(o => o.TotalCost);
                }


                var pagedOrders = await PagedList<Order>.Create(orders, filterDto.PageNumber ?? 1, filterDto.PageSize ?? 10);

                foreach (var order in pagedOrders.DataItems)
                {
                    foreach (var orderItem in order.OrderItems)
                    {
                        orderItem.SideDishes = orderItem.OrderItemSideDishes.Select(ois => ois.SideDish).ToList();
                    }
                }

                var getOrderVM = Mapper.Map<List<GetOrderVM>>(pagedOrders.DataItems);

                return new Message
                {
                    IsValid = true,
                    Status = ExceptionCode.Success,
                    Data = new
                    {
                        Orders = getOrderVM,
                        TotalCount = pagedOrders.TotalCount,
                        CurrentPage = pagedOrders.CurrentPage,
                        TotalPages = pagedOrders.TotalPages
                    },
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



        public async Task<Message> UpdateOrderStateAsMessageAsync(Guid orderId, OrderState newState, CancellationToken cancellationToken)
        {
            using var transaction = await _dbContext.Database.BeginTransactionAsync(cancellationToken);
            try
            {
                var order = await _dbContext.Orders.Include(o=>o.Restaurant)
                    .FirstOrDefaultAsync(o => o.Id == orderId, cancellationToken);
                var loggedUser = await _authContext.GetLoggedUser();

                if (order == null)
                {
                    return new Message
                    {
                        IsValid = false,
                        Status = ExceptionCode.NotFound,
                        Info = "Order not found."
                    };
                }

                if (order.OrderState == newState)
                {
                    return new Message
                    {
                        IsValid = true,
                        Status = ExceptionCode.Success,
                        Info = "Order state is already updated."
                    };
                }

                order.OrderState = newState;
                await _dbContext.SaveChangesAsync(cancellationToken);

                if (newState == OrderState.Delivered)
                {
                    try
                    {
                        await _hubContext.Clients.User(order.CreatedByUserId.ToString()).SendAsync("ReceiveNotification", "Your order has been delivered");

                        var notification = new Notification
                        {
                            Content = "Your order has been delivered",
                            CreatedDate = DateTime.Now,
                            IsDeleted = false,
                            SentByUserId = loggedUser.Id,
                            SentToUserId = order.CreatedByUserId,
                            RestaurantName = order?.Restaurant?.Name
                        };
                       await _dbContext.Notifications.AddAsync(notification, cancellationToken);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error sending notification: " + ex.Message);
                    }
                }

                await _dbContext.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);

                return new Message
                {
                    IsValid = true,
                    Status = ExceptionCode.Success,
                    Info = "Order state updated successfully."
                };
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync(cancellationToken);
                return new Message
                {
                    IsValid = false,
                    Status = ExceptionCode.BadRequest,
                    Info = $"Error updating order state: {ex.Message}"
                };
            }
        }
    }


}

