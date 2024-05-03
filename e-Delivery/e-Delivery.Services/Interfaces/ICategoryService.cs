using e_Delivery.Model.Category;
using e_Delivery.Model.City;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<Message> CreateCategoryAsMessageAsync(CategoryCreateVM categoryCreateVM,CancellationToken cancellationToken);
        Task<Message> GetCategoriesAsMessageAsync(CancellationToken cancellationToken, string? name, int items_per_page = 10, int pageNumber = 1);
        Task<Message> GetCategoryByIdAsMessageAsync(int id, CancellationToken cancellationToken);
        Task<Message> UpdateCategoryAsMessageAsync(int id, categoryUpdateVM categoryVM, CancellationToken cancellationToken);
        Task<Message> GetCategoriesWithFoodItemsForRestaurantAsMessageAsync(int restaurantID, CancellationToken cancellationToken);
        Task<Message> GetCategoriesUnPagedAsync(CancellationToken cancellationToken);
    }
}
