﻿using AutoMapper;
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
using e_Delivery.Services.PagedList;

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

        public async Task<Message> GetCitiesFilteredAsMessageAsync(CancellationToken cancellationToken, string? title, int items_per_page = 10, int pageNumber = 1)
        {
            try
            {
                var query = _dbContext.Cities.AsNoTracking().AsQueryable();

               
                if (!string.IsNullOrEmpty(title))
                {
                    query = query.Where(c => c.Title.StartsWith(title));
                }

                
                query = query.OrderByDescending(c => c.Id);

                
                var pagedCities = await PagedList<City>.Create(query, pageNumber, items_per_page);

                var citiesVM = Mapper.Map<List<CityGetVM>>(pagedCities.DataItems);

                return new Message
                {
                    IsValid = true,
                    Status = ExceptionCode.Success,
                    Info = "Successfully got cities",
                    Data = new { Cities = citiesVM, pagedCities.TotalPages, pagedCities.TotalCount }
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

        public async Task<Message> GetCityByAsMessageAsync(int id, CancellationToken cancellationToken)
        {
            try
            {
                var city = await _dbContext.Cities.FindAsync(id);
                var obj = Mapper.Map<CityGetVM>(city);

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
                    Status = ExceptionCode.NotFound
                };
            }
        }

        public async Task<Message> UpdateCityAsMessageAsync(int id,updateCityVM cityVM, CancellationToken cancellationToken)
        {
            try
            {
                var city = await _dbContext.Cities.FindAsync(id);
                city.Title = cityVM.Title;

               
                await _dbContext.SaveChangesAsync(cancellationToken);
                var obj = Mapper.Map<CityGetVM>(city);

                return new Message
                {
                    IsValid = true,
                    Status = ExceptionCode.Success,
                    Info = "Successfully updated city",
                    Data = obj
                };

            }
            catch (Exception ex)
            {

                return new Message
                {
                    IsValid = false,
                    Info = ex.Message,
                    Status = ExceptionCode.NotFound
                };
            }
        }

        public async Task<Message> GetCitiesAsMessageAsync(CancellationToken cancellationToken)
        {
            try
            {
                var city = await _dbContext.Cities.ToListAsync();
                var obj = Mapper.Map<List<CityGetVM>>(city);

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
                    Status = ExceptionCode.NotFound
                };
            }
        }
    }
}
