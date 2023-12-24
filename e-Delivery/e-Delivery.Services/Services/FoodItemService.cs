using AutoMapper;
using e_Delivery.Database;
using e_Delivery.Entities;
using e_Delivery.Entities.Enums;
using e_Delivery.Model.FoodItem;
using e_Delivery.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Services
{
    public class FoodItemService : IFoodItemService
    {
        public readonly eDeliveryDBContext _dbContext;
        public IMapper Mapper { get; set; }
        private IAuthContext authContext { get; set; }

        public FoodItemService(eDeliveryDBContext dbContext, IMapper mapper, IAuthContext AuthContext)
        {
            _dbContext = dbContext;
            Mapper = mapper;
            authContext = AuthContext;
        }

        public async Task<Message> CreateFoodItemAsMessageAsync(CreateFoodItemVM createFoodItemVM, CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await authContext.GetLoggedUser();
                var restaurant = await _dbContext.Restaurants.Where(x => x.Id == loggedUser.RestaurantId).FirstOrDefaultAsync();
                var foodItem = Mapper.Map<FoodItem>(createFoodItemVM);
                foodItem.RestaurantId = restaurant.Id;

                if (createFoodItemVM.SideDishIds != null && createFoodItemVM.SideDishIds.Any())
                {
                    foodItem.FoodItemSideDishMappings.AddRange(createFoodItemVM.SideDishIds
                    .Select(sideDishId => new FoodItemSideDishMapping { SideDishId = sideDishId }));
                }
                return new Message
                {
                    IsValid = true,
                    Info = "Successfully added FoodItem",
                    Status = ExceptionCode.Created,
                    Data = foodItem
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    IsValid = true,
                    Info = ex.Message,
                    Status = ExceptionCode.BadRequest,
                };
            }


        }
        public async Task<Message> RemoveSideDishesFromFoodItemAsync(int foodItemId, List<int> sideDishIds)
        {
            try
            {

                var foodItem = await _dbContext.FoodItems
                    .Include(fi => fi.FoodItemSideDishMappings)
                    .FirstOrDefaultAsync(fi => fi.Id == foodItemId);

                if (foodItem == null)
                {
                    // Handle not found case
                    return new Message
                    {
                        Info = "foodItem is null"
                    };
                }

                // Remove the specified side dishes
                var mappingsToRemove = foodItem.FoodItemSideDishMappings
                    .Where(mapping => sideDishIds.Contains(mapping.SideDishId))
                    .ToList();

                foreach (var mapping in mappingsToRemove)
                {
                    foodItem.FoodItemSideDishMappings.Remove(mapping);
                }

                await _dbContext.SaveChangesAsync();
                return new Message
                {
                    Info = "foodItem is null",
                    Status = ExceptionCode.Success,
                    IsValid = true,
                    Data = mappingsToRemove.ToArray()
                };
            }
            catch (Exception ex)
            {

                return new Message
                {
                    Info = ex.Message,
                    Status = ExceptionCode.BadRequest,
                    IsValid = false,
                   
                };
            }

        }

        public async Task<Message> GetFoodItemsAsMessageAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Message> GetFoodItemByIdAsMessageAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Message> UpdateFoodItemAsMessageAsync(int id, UpdateFoodItemVM updateFoodItemVM, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Message> DeleteFoodItemAsMessageAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
