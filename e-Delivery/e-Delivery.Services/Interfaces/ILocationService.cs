using e_Delivery.Model.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Interfaces
{
    public interface ILocationService
    {
        Task<Message> CreateLocationAsMessageAsync(LocationCreateVM locationCreateVM, CancellationToken cancellationToken);
        Task<Message> GetLocationAsMessageAsync(int Id, CancellationToken cancellationToken);
        Task<Message> DeleteLocationAsMessageAsync(int Id, CancellationToken cancellationToken);
        Task<Message> UpdateLocationAsMessageAsync(int Id, LocationUpdateVM locationUpdateVm, CancellationToken cancellationToken);
    }
}
