using e_Delivery.Model.FoodItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Interfaces
{
    public interface IFoodItemPicturesService
    {
        Task<Message> GetAllAsMessageAsync(int id);
        Task<Message> CreateAsMessageAsync(int id, FoodItemPictureAddVM vm);
        Task<Message> DeleteAsMessageAsync(int id);
    }
}
