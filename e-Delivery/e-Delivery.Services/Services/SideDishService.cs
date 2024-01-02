using AutoMapper;
using e_Delivery.Database;
using e_Delivery.Entities;
using e_Delivery.Entities.Enums;
using e_Delivery.Model.Auth;
using e_Delivery.Model.SideDish;
using e_Delivery.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Services
{
    public class SideDishService : ISideDishService
    {
        public readonly eDeliveryDBContext _dbContext;
        public IMapper Mapper { get; set; }
        private IAuthContext authContext { get; set; }

        public SideDishService(eDeliveryDBContext dbContext, IMapper mapper, IAuthContext AuthContext)
        {
            _dbContext = dbContext;
            Mapper = mapper;
            authContext = AuthContext;
        }
        public async Task<Message> CreateSideDishAsMessageAsync(CreateSideDishVM createSideDishVM, CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await authContext.GetLoggedUser();
                var _restaurant = await _dbContext.Restaurants.Where(x => x.Id == loggedUser.RestaurantId).FirstOrDefaultAsync();
                var resId = _restaurant.Id;
                
                var obj = Mapper.Map<SideDish>(createSideDishVM);

                obj.RestaurantId = resId;
                await _dbContext.AddAsync(obj);
                await _dbContext.SaveChangesAsync(cancellationToken);

                var sideDishGetVM = Mapper.Map<GetSideDishVM>(obj);

                return new Message
                {
                    Data = sideDishGetVM,
                    Info = "Successfully created side dish",
                    Status = ExceptionCode.Created,
                    IsValid = true
                };

            }
            catch (Exception ex)
            {

                return new Message
                {
                    Info = "Bad request",
                    Status = ExceptionCode.BadRequest,
                    IsValid = false
                };
            }
        }

        public async Task<Message> DeleteSideDishByRestaurantAsMessageAsync(int id, CancellationToken cancellationToken)
        {
            try
            {
                var sideDish = await _dbContext.SideDishes.FindAsync(id);

                var sideDishMappings = _dbContext.FoodItemSideDishMappings
                .Where(mapping => mapping.SideDishId == sideDish.Id);

                _dbContext.FoodItemSideDishMappings.RemoveRange(sideDishMappings);
                _dbContext.Remove(sideDish);
                await _dbContext.SaveChangesAsync(cancellationToken);

                return new Message
                {
                    IsValid = true,
                    Info = "Successfully deleted SideDish",
                    Status = ExceptionCode.NoContent,
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

        public async Task<Message> GetSideDishesByRestaurantAsMessageAsync(CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await authContext.GetLoggedUser();
                var restaurant = await _dbContext.Restaurants.Where(x=>x.Id == loggedUser.RestaurantId).FirstOrDefaultAsync();

                var sideDishes = await _dbContext.SideDishes.Where(x => x.RestaurantId == restaurant.Id).ToListAsync();

                var obj = Mapper.Map<List<GetSideDishVM>>(sideDishes);

                return new Message
                {
                    Data= obj,
                    IsValid = true,
                    Info = "Successfully retrieved SideDishes",
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

        public async Task<Message> UpdateSideDishAsMessageAsync(int id, UpdateSideDishVM updateSideDishVM, CancellationToken cancellationToken)
        {
            try
            {
                var sideDish = await _dbContext.SideDishes.FindAsync(id);
                var updatedSideDish = Mapper.Map(updateSideDishVM, sideDish);

                await _dbContext.SaveChangesAsync(cancellationToken);

                return new Message
                {
                    IsValid = true,
                    Info = "Successfully updated side dish",
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
