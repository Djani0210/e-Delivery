using AutoMapper;
using e_Delivery.Database;
using e_Delivery.Entities;
using e_Delivery.Entities.Enums;
using e_Delivery.Model.Location;
using e_Delivery.Model.Restaurant;
using e_Delivery.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Stripe.Terminal;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace e_Delivery.Services.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly eDeliveryDBContext _dbContext;
        public IMapper Mapper { get; set; }
        public IFileService _fileService { get; set; }
        public ILocationService _locationService { get; set; }
        public IAuthContext _authContext { get; set; }

        public RestaurantService(eDeliveryDBContext dbContext, IMapper mapper,
            IFileService fileService, ILocationService locationService, IAuthContext authContext)
        {
            _dbContext = dbContext;
            Mapper = mapper;
            _fileService = fileService;
            _locationService = locationService;
            _authContext = authContext;
        }
        public async Task<Message> CreateRestaurantAsMessage(RestaurantCreateVM restaurantCreateVM, CancellationToken cancellationToken)
        {
            try
            {
                var locationCreateVM = new LocationCreateVM
                {
                    CityId = restaurantCreateVM.CityId,
                    Latitude = restaurantCreateVM.Latitude,
                    Longitude = restaurantCreateVM.Longitude
                };
                var message = await _locationService.CreateLocationAsMessageAsync(locationCreateVM, cancellationToken);

                if (message == null || !message.IsValid)
                {
                    return new Message
                    {
                        IsValid = false,
                        Info = "Error during uploading a location!",
                        Status = ExceptionCode.BadRequest
                    };
                }
                var obj = Mapper.Map<Restaurant>(restaurantCreateVM);
                obj.CreatedDate = DateTime.Now;
                obj.LocationId = ((LocationGetVM)message.Data).Id;
                obj.OpeningTime = TimeSpan.ParseExact(restaurantCreateVM.OpeningTime, "hh\\:mm", CultureInfo.InvariantCulture);
                obj.ClosingTime = TimeSpan.ParseExact(restaurantCreateVM.ClosingTime, "hh\\:mm", CultureInfo.InvariantCulture);

                await _dbContext.AddAsync(obj);
                await _dbContext.SaveChangesAsync();
                return new Message
                {
                    IsValid = true,
                    Info = "Successfully added restaurant",
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

        public Task<Message> DeleteRestaurantAsMessage(int RestaurantId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Message> GetRestaurantByIdAsMessage(int RestaurantId, CancellationToken cancellationToken)
        {
            try
            {
                var restaurant = await _dbContext.Restaurants.Include(x => x.Logo).Include(x => x.Location).Include(x => x.Location.City).AsNoTracking().Where(x => x.Id == RestaurantId).FirstOrDefaultAsync(cancellationToken);


                var obj = Mapper.Map<RestaurantGetVM>(restaurant);
                return new Message
                {
                    IsValid = true,
                    Info = "Successfully got company",
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

        public async Task<Message> GetRestaurantsAsMessage(int cityId, CancellationToken cancellationToken)
        {
            try
            {
                var restaurants = await _dbContext.Restaurants.Include(x => x.Location).Include(x => x.Logo)
                .Include(x => x.Location.City)
                .Where(x => (cityId == null || cityId == x.Location.CityId))
                .ToListAsync(cancellationToken);

                var obj = Mapper.Map<List<RestaurantGetVM>>(restaurants);
                return new Message
                {
                    IsValid = true,
                    Info = "Successfully returned data",
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

        public async Task<Message> UpdateRestaurantAsMessage(int RestaurantId, RestaurantUpdateVM restaurantUpdateVM, CancellationToken cancellationToken)
        {
            try
            {
                var restaurant = await _dbContext.Restaurants.Include(x => x.Location)
                    .Include(x => x.Location.City).Where(x => x.Id == RestaurantId).FirstOrDefaultAsync(cancellationToken);
                Mapper.Map(restaurantUpdateVM, restaurant);
                restaurant.OpeningTime = TimeSpan.ParseExact(restaurantUpdateVM.OpeningTime, "hh\\:mm", CultureInfo.InvariantCulture);
                restaurant.ClosingTime = TimeSpan.ParseExact(restaurantUpdateVM.ClosingTime, "hh\\:mm", CultureInfo.InvariantCulture);

                var location = await _dbContext.Locations.Where(x => x.Latitude == restaurantUpdateVM.Latitude && x.Longitude == restaurantUpdateVM.Longitude).FirstOrDefaultAsync(cancellationToken);
                if (location == null)
                {
                    LocationCreateVM locationCreateDto = new LocationCreateVM { CityId = restaurantUpdateVM.CityId, Latitude = restaurantUpdateVM.Latitude, Longitude = restaurantUpdateVM.Longitude };
                    var message2 = await _locationService.CreateLocationAsMessageAsync(locationCreateDto, cancellationToken);
                    if (message2 == null || !message2.IsValid)
                    {
                        return new Message
                        {
                            IsValid = false,
                            Info = "Error during uploading a location!",
                            Status = ExceptionCode.BadRequest
                        };
                    }
                    restaurant.LocationId = ((LocationGetVM)message2.Data).Id;
                }
                restaurant.Location.CityId = restaurantUpdateVM.CityId;

                await _dbContext.SaveChangesAsync(cancellationToken);

                return new Message
                {
                    IsValid = true,
                    Info = "Successfully updated company",
                    Status = ExceptionCode.Success,
                    Data = restaurant
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
