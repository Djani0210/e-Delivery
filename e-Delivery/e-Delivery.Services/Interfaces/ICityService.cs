using e_Delivery.Model.City;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Interfaces
{
    public interface ICityService
    {
         Task<Message> CreateCityAsMessageAsync(CityCreateVM createCityVM, CancellationToken cancellationToken);
         Task<Message> GetCitiesFilteredAsMessageAsync(CancellationToken cancellationToken, string? title, int items_per_page = 10, int pageNumber = 1);
         Task<Message> GetCitiesAsMessageAsync(CancellationToken cancellationToken);
         Task<Message> GetCityByAsMessageAsync(int id, CancellationToken cancellationToken);
         Task<Message> UpdateCityAsMessageAsync(int id,updateCityVM cityVM, CancellationToken cancellationToken);




    }
}
