using e_Delivery.Model.Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Interfaces
{
    public interface IRestaurantService
    {
        Task<Message> CreateRestaurantAsMessage(RestaurantCreateVM restaurantCreateVM, CancellationToken cancellationToken);
        Task<Message> UpdateRestaurantAsMessage(int RestaurantId, RestaurantUpdateVM restaurantUpdateVM, CancellationToken cancellationToken);
        Task<Message> DeleteRestaurantAndRelatedEntitiesAsync(int restaurantId,  CancellationToken cancellationToken);
        Task<Message> GetRestaurantsAsMessage(int cityId, CancellationToken cancellationToken);
        Task<Message> GetRestaurantByIdAsMessage(int RestaurantId, CancellationToken cancellationToken);

    }
}
