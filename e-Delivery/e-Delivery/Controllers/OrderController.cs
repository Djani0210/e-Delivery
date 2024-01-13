using e_Delivery.Model.City;
using e_Delivery.Model.FoodItem;
using e_Delivery.Model.Order;
using e_Delivery.Model.Restaurant;
using e_Delivery.Model.SideDish;
using e_Delivery.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace e_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("create-Order"), Authorize(Roles = "MobileClient")]
        public async Task<IActionResult> CreateOrder(CreateOrderVM createOrderVm, CancellationToken cancellationToken)
        {
            var message = await _orderService.CreateOrderAsMessageAsync(createOrderVm, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }
        //[HttpPatch("{foodItemId}/removesidedishes"), Authorize(Roles = "Desktop")]
        //public async Task<IActionResult> RemoveSideDishesFromFoodItem(int foodItemId,[FromBody] List<int> sideDishIds)
        //{
        //    var message = await _foodItemService.RemoveSideDishesFromFoodItemAsync(foodItemId, sideDishIds);
        //    if (!message.IsValid)
        //    {
        //        return BadRequest(message);
        //    }
        //    return Ok(message);
        //}

        [HttpPut("update-Order"), Authorize(Roles = "MobileClient")]
        public async Task<IActionResult> UpdateRestaurant(Guid id ,UpdateOrderVM updateOrderVM, CancellationToken cancellationToken)
        {
            var message = await _orderService.UpdateOrderAsMessageAsync(id, updateOrderVM, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpGet("get-Order-By-Id"), Authorize()]
        public async Task<IActionResult> GetOrderById(Guid id, CancellationToken cancellationToken)
        {
            var message= await _orderService.GetOrderByIdAsMessageAsync(id, cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpGet("get-Orders-For-DeliveryPerson"), Authorize()]
        public async Task<IActionResult> GetOrdersForDeliveryPerson( CancellationToken cancellationToken)
        {
            var message = await _orderService.GetOrdersForDeliveryPersonAsMessageAsync(cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

        [HttpGet("get-Orders-For-Customer"), Authorize()]
        public async Task<IActionResult> GetOrdersForCustomer(CancellationToken cancellationToken)
        {
            var message = await _orderService.GetOrdersForCustomerAsMessageAsync(cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }
        [HttpDelete("delete-Order"), Authorize()]
        public async Task<IActionResult> DeleteOrder(Guid id, CancellationToken cancellationToken)
        {
            var message = await _orderService.DeleteOrderAsMessageAsync(id,cancellationToken);
            if (!message.IsValid)
            {
                return BadRequest(message);
            }
            return Ok(message);
        }

    }
}
