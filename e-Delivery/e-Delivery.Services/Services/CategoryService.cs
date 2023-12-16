using AutoMapper;
using e_Delivery.Database;
using e_Delivery.Entities;
using e_Delivery.Entities.Enums;
using e_Delivery.Model.Category;
using e_Delivery.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Services
{
    public class CategoryService : ICategoryService
    {
        public readonly eDeliveryDBContext _dbContext;
        public IMapper Mapper { get; set; }
        private IAuthContext authContext { get; set; }

        public CategoryService(eDeliveryDBContext dbContext, IMapper mapper, IAuthContext AuthContext)
        {
            _dbContext = dbContext;
            Mapper = mapper;
            authContext = AuthContext;
        }
        public async Task<Message> CreateCategoryAsMessageAsync(CategoryCreateVM categoryCreateVM, CancellationToken cancellationToken)
        {
            try
            {
                var obj = Mapper.Map<Category>(categoryCreateVM);
                obj.CreatedDate = DateTime.Now;
                await _dbContext.AddAsync(obj);
                await _dbContext.SaveChangesAsync(cancellationToken);
                return new Message
                {
                    IsValid = true,
                    Info = "Successfully created category",
                    Status = ExceptionCode.Success,
                    Data = obj
                };

            }
            catch (Exception ex)
            {

                return new Message
                {
                    IsValid = false,
                    Info = ex.Message,
                    Status = ExceptionCode.BadRequest
                };
            }
        }

        public async Task<Message> GetCategoriesAsMessageAsync(CancellationToken cancellationToken)
        {
            try
            {
                var categories = await _dbContext.Categories.AsNoTracking().ToListAsync();
                var obj = Mapper.Map<List<CategoriesGetVM>>(categories);
                return new Message
                {
                    IsValid = true,
                    Info = "Successfully retrieved categories",
                    Status = ExceptionCode.Success,
                    Data = obj
                };
            }
            catch (Exception ex)
            {

                return new Message
                {
                    IsValid = false,
                    Info = ex.Message,
                    Status = ExceptionCode.BadRequest
                };
            }
        }

        public async Task<Message> GetCategoriesWithFoodItemsForRestaurantAsMessageAsync(int restaurantId, CancellationToken cancellationToken)
        {
            try
            {
                var categoriesWithFoodItems = await _dbContext.Categories
                .Where(c => c.FoodItems.Any(fi => fi.RestaurantId == restaurantId))
                .Include(c => c.FoodItems)
                .AsQueryable()
                .ToListAsync();
                var obj = Mapper.Map<List<CategoriesWithFoodItemsGetVM>>(categoriesWithFoodItems);
                return new Message
                {
                    IsValid = true,
                    Info = "Successfully retrieved categories with food items",
                    Status = ExceptionCode.Success,
                    Data = obj
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    IsValid = false,
                    Info = ex.Message,
                    Status = ExceptionCode.BadRequest
                };
            }


        }
    }
}
