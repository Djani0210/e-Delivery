using AutoMapper;
using e_Delivery.Database;
using e_Delivery.Entities;
using e_Delivery.Entities.Enums;
using e_Delivery.Model.City;
using e_Delivery.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Services
{
    public class CityService : ICityService
    {
        public readonly eDeliveryDBContext _dbContext;
        public IMapper Mapper { get; set; }
        private IAuthContext authContext { get; set; }

        public CityService(eDeliveryDBContext dbContext, IMapper mapper, IAuthContext AuthContext)
        {
            _dbContext = dbContext;
            Mapper = mapper;
            authContext = AuthContext;
        }

        public async Task<Message> CreateCityAsMessageAsync(CityCreateVM cityCreateVM, CancellationToken cancellationToken)
        {
            try
            {
                var obj = Mapper.Map<City>(cityCreateVM);
                obj.CreatedDate = DateTime.Now;

                await _dbContext.Cities.AddAsync(obj);
                await _dbContext.SaveChangesAsync(cancellationToken);
                return new Message
                {
                    IsValid = true,
                    Info = "Successfully added city",
                    Status = ExceptionCode.Success,
                    Data = obj
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

        public async Task<Message> GetCitiesAsMessageAsync(CancellationToken cancellationToken)
        {
            try
            {
                var cities = await _dbContext.Cities.AsNoTracking().ToListAsync(cancellationToken);
                var obj=Mapper.Map<List<CityGetVM>>(cities);
                
                    return new Message
                    {
                        IsValid = true,
                        Status = ExceptionCode.Success,
                        Info = "Successfully got cities",
                        Data = obj
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
