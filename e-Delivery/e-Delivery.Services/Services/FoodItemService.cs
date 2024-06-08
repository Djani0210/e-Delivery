using AutoMapper;
using e_Delivery.Database;
using e_Delivery.Entities;
using e_Delivery.Entities.Enums;
using e_Delivery.Model.Category;
using e_Delivery.Model.FoodItem;
using e_Delivery.Model.SideDish;
using e_Delivery.Services.Interfaces;
using e_Delivery.Services.PagedList;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
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

                await _dbContext.AddAsync(foodItem);
                await _dbContext.SaveChangesAsync(cancellationToken);
                var foodItemGetVM = Mapper.Map<FoodItemGetVM>(foodItem);
                return new Message
                {
                    IsValid = true,
                    Info = "Successfully added FoodItem",
                    Status = ExceptionCode.Created,
                    Data = foodItemGetVM
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


        public async Task<Message> GetFoodItemsAsMessageAsync(CancellationToken cancellationToken, string? categoryName = null, int items_per_page = 4, int pageNumber = 1, bool? isAvailable = null, string? itemName = null)
        {
            try
            {
                var loggedUser = await authContext.GetLoggedUser();
                var restaurant = await _dbContext.Restaurants.FirstOrDefaultAsync(x => x.Id == loggedUser.RestaurantId);


                IQueryable<FoodItem> query = _dbContext.FoodItems
                                                       .Include(x => x.Category)
                                                       .Include(x => x.FoodItemSideDishMappings)
                                                           .ThenInclude(sdm => sdm.SideDish)
                                                       .Where(fi => fi.RestaurantId == restaurant.Id);


                if (!string.IsNullOrEmpty(categoryName))
                {
                    query = query.Where(fi => fi.Category.Name == categoryName);
                }
                if (!string.IsNullOrEmpty(itemName))
                {
                    query = query.Where(fi => fi.Name.StartsWith(itemName));
                }
                if (isAvailable.HasValue)
                {
                    query = query.Where(fi => fi.IsAvailable == isAvailable.Value);
                }


                var pagedFoodItems = await PagedList<FoodItem>.Create(query, pageNumber, items_per_page);

                var getFoodItemsVM = pagedFoodItems.DataItems.Select(fi => new FoodItemGetVM
                {
                    Id = fi.Id,
                    Name = fi.Name,
                    Description = fi.Description,
                    Price = fi.Price,
                    IsAvailable = fi.IsAvailable,
                    Category = new CategoriesGetVM { Name = fi.Category?.Name },
                    SideDishes = fi.FoodItemSideDishMappings.Select(mapping => new GetSideDishVM
                    {
                        Id = mapping.SideDish.Id,
                        Name = mapping.SideDish.Name,
                        Price = mapping.SideDish.Price,
                        IsAvailable = mapping.SideDish.IsAvailable
                    }).ToList()
                }).ToList();

                return new Message
                {
                    IsValid = true,
                    Info = "Successfully retrieved filtered and paginated FoodItems for the restaurant.",
                    Status = ExceptionCode.Success,
                    Data = new { MenuItems = getFoodItemsVM, pagedFoodItems.TotalPages, pagedFoodItems.TotalCount }
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    IsValid = false,
                    Info = ex.Message,
                    Status = ExceptionCode.BadRequest,
                };
            }
        }





        public async Task<Message> GetFoodItemByIdAsMessageAsync(int foodItemId, CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await authContext.GetLoggedUser();
                var restaurant = await _dbContext.Restaurants.Where(x => x.Id == loggedUser.RestaurantId).FirstOrDefaultAsync();

                var foodItem = await _dbContext.FoodItems
                    .Where(fi => fi.Id == foodItemId && fi.RestaurantId == restaurant.Id)
                    .Select(fi => new
                    {
                        FoodItem = fi,
                        SideDishes = fi.FoodItemSideDishMappings.Select(mapping => mapping.SideDish).ToList()
                    })
                    .SingleOrDefaultAsync();

                if (foodItem == null)
                {
                    return new Message
                    {
                        IsValid = false,
                        Info = "FoodItem not found or does not belong to the restaurant.",
                        Status = ExceptionCode.NotFound,
                    };
                }

                var getFoodItemVM = new FoodItemGetVM
                {
                    Id = foodItem.FoodItem.Id,
                    Name = foodItem.FoodItem.Name,
                    Description = foodItem.FoodItem.Description,
                    Price = foodItem.FoodItem.Price,
                    IsAvailable = foodItem.FoodItem.IsAvailable,
                    SideDishes = Mapper.Map<List<GetSideDishVM>>(foodItem.SideDishes)
                    // Add other properties as needed
                };

                return new Message
                {
                    IsValid = true,
                    Info = "Successfully retrieved FoodItem.",
                    Status = ExceptionCode.Success,
                    Data = getFoodItemVM
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    IsValid = false,
                    Info = ex.Message,
                    Status = ExceptionCode.BadRequest,
                };
            }
        }

        public async Task<string> GetFoodItemNameById(int id)
        {
            try
            {
                var foodItem = await _dbContext.FoodItems.FindAsync(id);

                if (foodItem != null)
                {
                    return foodItem.Name;
                }
                else
                {
                    return "Item not found";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get food item name", ex);
            }
        }




        public async Task<Message> UpdateFoodItemAsMessageAsync(int foodItemId, UpdateFoodItemVM updateFoodItemVM, CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await authContext.GetLoggedUser();
                var restaurant = await _dbContext.Restaurants.Where(x => x.Id == loggedUser.RestaurantId).FirstOrDefaultAsync();

                var existingFoodItem = await _dbContext.FoodItems
                    .Include(fi => fi.FoodItemSideDishMappings)
                    .SingleOrDefaultAsync(fi => fi.Id == foodItemId && fi.RestaurantId == restaurant.Id);

                if (existingFoodItem == null)
                {
                    return new Message
                    {
                        IsValid = false,
                        Info = "FoodItem not found or does not belong to the restaurant.",
                        Status = ExceptionCode.NotFound,
                    };
                }

                // Update properties
                Mapper.Map(updateFoodItemVM, existingFoodItem);

                // Update side dishes
                existingFoodItem.FoodItemSideDishMappings.Clear(); // Remove existing side dish mappings
                if (updateFoodItemVM.SideDishIds != null && updateFoodItemVM.SideDishIds.Any())
                {
                    existingFoodItem.FoodItemSideDishMappings.AddRange(updateFoodItemVM.SideDishIds
                        .Select(sideDishId => new FoodItemSideDishMapping { SideDishId = sideDishId }));
                }

                await _dbContext.SaveChangesAsync();

                return new Message
                {
                    IsValid = true,
                    Info = "Successfully updated FoodItem.",
                    Status = ExceptionCode.Success,
                    Data = existingFoodItem
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    IsValid = false,
                    Info = ex.Message,
                    Status = ExceptionCode.BadRequest,
                };
            }
        }
        public async Task<Message> DeleteFoodItemAsMessageAsync(int foodItemId, CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await authContext.GetLoggedUser();
                var restaurant = await _dbContext.Restaurants.Where(x => x.Id == loggedUser.RestaurantId).FirstOrDefaultAsync();

                var existingFoodItem = await _dbContext.FoodItems.Include(fi => fi.FoodItemPictures)
                    .SingleOrDefaultAsync(fi => fi.Id == foodItemId && fi.RestaurantId == restaurant.Id);

                if (existingFoodItem == null)
                {
                    return new Message
                    {
                        IsValid = false,
                        Info = "FoodItem not found or does not belong to the restaurant.",
                        Status = ExceptionCode.NotFound,
                    };
                }
                var sideDishMappings = _dbContext.FoodItemSideDishMappings
                .Where(mapping => mapping.FoodItemId == existingFoodItem.Id);

                _dbContext.FoodItemSideDishMappings.RemoveRange(sideDishMappings);

                _dbContext.FoodItems.Remove(existingFoodItem);
                await _dbContext.SaveChangesAsync();

                return new Message
                {
                    IsValid = true,
                    Info = "Successfully deleted FoodItem.",
                    Status = ExceptionCode.Success,
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    IsValid = false,
                    Info = ex.Message,
                    Status = ExceptionCode.BadRequest,
                };
            }
        }

    }
}
