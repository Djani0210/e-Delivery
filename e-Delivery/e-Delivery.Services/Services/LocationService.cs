using AutoMapper;
using e_Delivery.Database;
using e_Delivery.Entities;
using e_Delivery.Entities.Enums;
using e_Delivery.Model.Location;
using e_Delivery.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Services
{
    public class LocationService : ILocationService
    {
        public readonly eDeliveryDBContext _dbContext;
        public IMapper Mapper { get; set; }
        private IAuthContext authContext { get; set; }

        public LocationService(eDeliveryDBContext dbContext, IMapper mapper, IAuthContext authContext)
        {
            _dbContext = dbContext;
            Mapper = mapper;
            this.authContext = authContext;
        }
        public async Task<Message> CreateLocationAsMessageAsync(LocationCreateVM locationCreateVM, CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await authContext.GetLoggedUser();
                var obj = Mapper.Map<Location>(locationCreateVM);
                obj.CreatedDate = DateTime.Now;
                obj.CreatedByUserId = loggedUser.Id;
                obj.ModifiedByUserId = loggedUser.Id;

                await _dbContext.Locations.AddAsync(obj);
                await _dbContext.SaveChangesAsync(cancellationToken);
                return new Message
                {
                    IsValid = true,
                    Info = "Successfully added location",
                    Status = ExceptionCode.Success,
                    Data = Mapper.Map<LocationGetVM>(obj)
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

        public async Task<Message> DeleteLocationAsMessageAsync(int Id, CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await authContext.GetLoggedUser();

                var obj = await _dbContext.Locations.Where(x => x.Id == Id).FirstOrDefaultAsync(cancellationToken);
                obj.IsDeleted = true;
                obj.ModifiedByUserId = loggedUser.Id;
                await _dbContext.SaveChangesAsync(cancellationToken);

                return new Message
                {
                    IsValid = true,
                    Info = "Successfully deleted location",
                    Status = ExceptionCode.Success,
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

        public async Task<Message> GetLocationAsMessageAsync(int Id, CancellationToken cancellationToken)
        {
            try
            {
                var location = await _dbContext.Locations.Include(x => x.City).AsNoTracking().Where(x => x.Id == Id).FirstOrDefaultAsync(cancellationToken);

                if (location != null)
                {
                    var obj = Mapper.Map<LocationGetVM>(location);
                    return new Message
                    {
                        IsValid = true,
                        Info = "Successfully got location",
                        Status = ExceptionCode.Success,
                        Data = obj
                    };
                }
                return new Message
                {
                    IsValid = true,
                    Status = ExceptionCode.Success
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

        public async Task<Message> UpdateLocationAsMessageAsync(int Id, LocationUpdateVM locationUpdateVm, CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await authContext.GetLoggedUser();

                var obj = await _dbContext.Locations.Where(x => x.Id == Id).FirstOrDefaultAsync(cancellationToken);
                var realObj = Mapper.Map(locationUpdateVm, obj);
                realObj.ModifiedByUserId = loggedUser.Id;

                await _dbContext.SaveChangesAsync(cancellationToken);

                return new Message
                {
                    IsValid = true,
                    Info = "Successfully updated location",
                    Status = ExceptionCode.Success,
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
    }
}
