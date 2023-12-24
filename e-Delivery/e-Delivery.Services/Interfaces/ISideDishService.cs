using e_Delivery.Model.City;
using e_Delivery.Model.SideDish;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Interfaces
{
    public interface ISideDishService
    {
        Task<Message> CreateSideDishAsMessageAsync(CreateSideDishVM createSideDishVM, CancellationToken cancellationToken);
        Task<Message> UpdateSideDishAsMessageAsync(int id, UpdateSideDishVM updateSideDishVM, CancellationToken cancellationToken);
        Task<Message> GetSideDishesByRestaurantAsMessageAsync(CancellationToken cancellationToken);
        Task<Message> DeleteSideDishByRestaurantAsMessageAsync(int id, CancellationToken cancellationToken);
    }
}
