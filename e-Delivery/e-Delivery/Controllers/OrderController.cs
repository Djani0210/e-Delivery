using e_Delivery.Database;
using e_Delivery.Entities.Enums;
using e_Delivery.Model.City;
using e_Delivery.Model.FoodItem;
using e_Delivery.Model.Order;
using e_Delivery.Model.Restaurant;
using e_Delivery.Model.SideDish;
using e_Delivery.Services.Interfaces;
using e_Delivery.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly eDeliveryDBContext _dbContext;
        public IAuthContext _authContext { get; set; }
        public OrderController(eDeliveryDBContext dbContext, IOrderService orderService, IAuthContext authContext)
        {
            _orderService = orderService;
            _dbContext = dbContext;
            _authContext = authContext;
        }

        [HttpPost("create-Order"), Authorize(Roles = "MobileCustomer")]
        public async Task<IActionResult> CreateOrder(CreateOrderVM createOrderVm, CancellationToken cancellationToken)
        {
            var message = await _orderService.CreateOrderAsMessageAsync(createOrderVm, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }
        

        

        [HttpGet("get-Order-By-Id"), Authorize()]
        public async Task<IActionResult> GetOrderById(Guid id, CancellationToken cancellationToken)
        {
            var message = await _orderService.GetOrderByIdAsMessageAsync(id, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpGet("get-Orders-For-Restaurant"), Authorize(Roles = "Desktop")]
        public async Task<IActionResult> GetOrderForRestaurant(CancellationToken cancellationToken, int items_per_page = 4, int pageNumber = 1, DateTime? startDate = null, // Adding startDate parameter
         DateTime? endDate = null, int? orderState = null)
        {
            var message = await _orderService.GetOrderByRestaurantAsMessageAsync(cancellationToken, items_per_page, pageNumber, startDate, endDate, orderState);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpGet("monthly-count"), Authorize(Roles = "Desktop")]
        public async Task<ActionResult<int>> GetMonthlyOrderCount()
        {
            var loggedUser = await _authContext.GetLoggedUser();
            var now = DateTime.UtcNow;
            var count = await _dbContext.Orders
                .Where(o => o.CreatedDate.Year == now.Year && o.CreatedDate.Month == now.Month && !o.IsDeleted && o.RestaurantId == loggedUser.RestaurantId)
                .CountAsync();
            return Ok(count);
        }



        [HttpGet("get-Orders-For-DeliveryPerson"), Authorize()]
        public async Task<IActionResult> GetOrderForDeliveryPerson(
                [FromQuery] DateTime? startDate,
                [FromQuery] DateTime? endDate,
                [FromQuery] OrderState? orderState,
                [FromQuery] string? sortBy,
                [FromQuery] int? pageNumber,
                [FromQuery] int? pageSize,
                CancellationToken cancellationToken)
        {
            var filterDto = new GetOrdersFilterDto
            {
                StartDate = startDate,
                EndDate = endDate,
                OrderState = orderState,
                SortBy = sortBy,
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            var message = await _orderService.GetOrdersForDeliveryPersonAsMessageAsync(filterDto, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpPatch("assign-delivery-person"), Authorize(Roles = "Desktop")]
        public async Task<IActionResult> AssignDeliveryPerson([FromBody] AssignDeliveryPersonRequest request, CancellationToken cancellationToken)
        {
            var message = await _orderService.AssignDeliveryPersonToOrderAsMessageAsync(request.OrderId, request.UserId, cancellationToken);

            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpGet("get-Orders-For-Customer"), Authorize()]
        public async Task<IActionResult> GetOrdersForCustomer(
                [FromQuery] DateTime? startDate,
                [FromQuery] DateTime? endDate,
                [FromQuery] OrderState? orderState,
                [FromQuery] string? sortBy,
                [FromQuery] int? pageNumber,
                [FromQuery] int? pageSize,
                CancellationToken cancellationToken)
        {
            var filterDto = new GetOrdersFilterDto
            {
                StartDate = startDate,
                EndDate = endDate,
                OrderState = orderState,
                SortBy = sortBy,
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            var message = await _orderService.GetOrdersForCustomerAsMessageAsync(filterDto, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }
        [HttpDelete("delete-Order"), Authorize()]
        public async Task<IActionResult> DeleteOrder(Guid id, CancellationToken cancellationToken)
        {
            var message = await _orderService.DeleteOrderAsMessageAsync(id, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpPatch("{orderId}/state"), Authorize()]
        public async Task<IActionResult> PatchOrderState(Guid orderId, [FromBody] OrderStateUpdateDto newStateModel, CancellationToken cancellationToken)
        {
            var message = await _orderService.UpdateOrderStateAsMessageAsync(orderId, newStateModel.NewState, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }

            return Ok(message);
        }

    }
}
