using e_Delivery.Model.Category;
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
        Task<Message> GetCategoriesAsMessageAsync(CancellationToken cancellationToken);
        Task<Message> GetCategoriesWithFoodItemsForRestaurantAsMessageAsync(int restaurantID, CancellationToken cancellationToken);
    }
}
