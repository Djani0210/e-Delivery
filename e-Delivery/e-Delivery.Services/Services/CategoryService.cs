using AutoMapper;
using e_Delivery.Database;
using e_Delivery.Entities;
using e_Delivery.Entities.Enums;
using e_Delivery.Model.Category;
using e_Delivery.Model.City;
using e_Delivery.Services.Interfaces;
using e_Delivery.Services.PagedList;
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

        public async Task<Message> GetCategoriesAsMessageAsync(CancellationToken cancellationToken, string? name, int items_per_page = 10, int pageNumber = 1)
        {
            try
            {
                var query = _dbContext.Categories.AsNoTracking().AsQueryable();

                if (!string.IsNullOrEmpty(name))
                {
                    query = query.Where(c => c.Name.StartsWith(name));
                }
                query = query.OrderByDescending(c => c.Id);

                var pagedCategories = await PagedList<Category>.Create(query, pageNumber, items_per_page);

                var citiesVM = Mapper.Map<List<CategoriesGetVM>>(pagedCategories.DataItems);

                return new Message
                {
                    IsValid = true,
                    Status = ExceptionCode.Success,
                    Info = "Successfully got categories",
                    Data = new { Categories = citiesVM, pagedCategories.TotalPages, pagedCategories.TotalCount }
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

        public async Task<Message> GetCategoryByIdAsMessageAsync(int id, CancellationToken cancellationToken)
        {
            try
            {
                var category = await _dbContext.Categories.FindAsync(id);
                var obj = Mapper.Map<CategoriesGetVM>(category);

                return new Message
                {
                    IsValid = true,
                    Status = ExceptionCode.Success,
                    Info = "Successfully got category",
                    Data = obj
                };

            }
            catch (Exception ex)
            {
                return new Message
                {
                    IsValid = false,
                    Info = ex.Message,
                    Status = ExceptionCode.NotFound
                };
            }
        }

        public async Task<Message> UpdateCategoryAsMessageAsync(int id, categoryUpdateVM categoryVM, CancellationToken cancellationToken)
        {
            try
            {
                var category = await _dbContext.Categories.FindAsync(id);
                category.Name = categoryVM.Name;


                await _dbContext.SaveChangesAsync(cancellationToken);
                var obj = Mapper.Map<CategoriesGetVM>(category);

                return new Message
                {
                    IsValid = true,
                    Status = ExceptionCode.Success,
                    Info = "Successfully updated category",
                    Data = obj
                };

            }
            catch (Exception ex)
            {

                return new Message
                {
                    IsValid = false,
                    Info = ex.Message,
                    Status = ExceptionCode.NotFound
                };
            }
        }

        public async Task<Message> GetCategoriesUnPagedAsync(CancellationToken cancellationToken)
        {
            try
            {
                var categories = await _dbContext.Categories.ToListAsync();
                var obj = Mapper.Map<List<CategoriesGetVM>>(categories);

                return new Message { Data = obj, Info = "Successfully retrieved categories", IsValid = true, Status = ExceptionCode.Success };
            }
            catch (Exception ex)
            {

                return new Message
                {
                    IsValid = false,
                    Info = ex.Message,
                    Status = ExceptionCode.NotFound
                };
            }
        }
    }
}
