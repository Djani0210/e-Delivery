using e_Delivery.Model.Category;
using e_Delivery.Model.FoodItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Interfaces
{
    public interface IFoodItemService
    {
        Task<Message> CreateFoodItemAsMessageAsync(CreateFoodItemVM createFoodItemVM, CancellationToken cancellationToken);
        Task<Message> GetFoodItemsAsMessageAsync(CancellationToken cancellationToken,string? categoryName = null, int items_per_page = 4, int pageNumber = 1, bool? isAvailable = null, string? itemName = null);
        Task<Message> GetFoodItemByIdAsMessageAsync(int id, CancellationToken cancellationToken);
        Task<Message> UpdateFoodItemAsMessageAsync(int id,UpdateFoodItemVM updateFoodItemVM, CancellationToken cancellationToken);
        Task<Message> DeleteFoodItemAsMessageAsync(int id, CancellationToken cancellationToken);
        Task<Message> RemoveSideDishesFromFoodItemAsync(int foodItemId, List<int> sideDishIds);
        Task<string> GetFoodItemNameById(int id);


    }
}
