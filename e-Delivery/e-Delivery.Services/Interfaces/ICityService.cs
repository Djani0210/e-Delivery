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
         Task<Message> GetCitiesAsMessageAsync(CancellationToken cancellationToken);
    }
}
