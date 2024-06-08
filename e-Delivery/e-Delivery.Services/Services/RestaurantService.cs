using AutoMapper;
using e_Delivery.Database;
using e_Delivery.Entities;
using e_Delivery.Entities.Enums;
using e_Delivery.Model.City;
using e_Delivery.Model.Images;
using e_Delivery.Model.Location;
using e_Delivery.Model.Restaurant;
using e_Delivery.Model.Review;
using e_Delivery.Model.User;
using e_Delivery.Services.Interfaces;
using e_Delivery.Services.PagedList;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Stripe.Terminal;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
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
        private UserManager<User> _userManager { get; set; }
        private RoleManager<Role> _roleManager { get; set; }

        public RestaurantService(eDeliveryDBContext dbContext, IMapper mapper,
            IFileService fileService, ILocationService locationService, IAuthContext authContext, UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _dbContext = dbContext;
            Mapper = mapper;
            _fileService = fileService;
            _locationService = locationService;
            _authContext = authContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<Message> CreateRestaurantAsMessage(RestaurantCreateVM restaurantCreateVM, CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await _authContext.GetLoggedUser();

                if (loggedUser.RestaurantId == null)
                {
                    using var transaction = await _dbContext.Database.BeginTransactionAsync();

                    try
                    {
                        // Your existing code to create a location
                        var locationCreateVM = new LocationCreateVM
                        {
                            CityId = restaurantCreateVM.CityId,
                            Latitude = restaurantCreateVM.Latitude,
                            Longitude = restaurantCreateVM.Longitude
                        };
                        var locationMessage = await _locationService.CreateLocationAsMessageAsync(locationCreateVM, cancellationToken);

                        if (locationMessage == null || !locationMessage.IsValid)
                        {
                            transaction.Rollback();
                            return new Message
                            {
                                IsValid = false,
                                Info = "Error during uploading a location!",
                                Status = ExceptionCode.BadRequest
                            };
                        }

                        var obj = Mapper.Map<Restaurant>(restaurantCreateVM);
                        obj.CreatedByUserId = loggedUser.Id;
                        obj.ModifiedByUserId = loggedUser.Id;
                        obj.CreatedDate = DateTime.Now;
                        obj.LocationId = ((LocationGetVM)locationMessage.Data).Id;
                        obj.OpeningTime = TimeSpan.ParseExact(restaurantCreateVM.OpeningTime, "hh\\:mm", CultureInfo.InvariantCulture);
                        obj.ClosingTime = TimeSpan.ParseExact(restaurantCreateVM.ClosingTime, "hh\\:mm", CultureInfo.InvariantCulture);

                        await _dbContext.AddAsync(obj);
                        await _dbContext.SaveChangesAsync(cancellationToken);

                        // Update user's RestaurantId
                        var userEntity = await _userManager.FindByIdAsync(loggedUser.Id.ToString());
                        userEntity.RestaurantId = obj.Id; // Assuming obj.Id is the generated Id for the newly created restaurant
                        await _userManager.UpdateAsync(userEntity);

                        transaction.Commit();
                        var restaurantGetVM = Mapper.Map<RestaurantGetVM>(obj);

                        return new Message
                        {
                            IsValid = true,
                            Info = "Successfully added restaurant",
                            Status = ExceptionCode.Created,
                            Data = restaurantGetVM
                        };
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        return new Message
                        {
                            IsValid = false,
                            Info = ex.Message,
                            Status = ExceptionCode.BadRequest
                        };
                    }
                }
                else
                {
                    return new Message
                    {
                        IsValid = false,
                        Info = "This user has already got a restaurant",
                        Status = ExceptionCode.BadRequest
                    };
                }
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



        public async Task<Message> DeleteRestaurantAndRelatedEntitiesAsync(int restaurantId, CancellationToken cancellationToken)
        {
            using var transaction = await _dbContext.Database.BeginTransactionAsync();

            try
            {

                var loggedUser = await _authContext.GetLoggedUser();




                var foodItemPicturesToDelete = await _dbContext.FoodItemPictures
                    .Where(fip => fip.FoodItem.RestaurantId == restaurantId)
                    .ToListAsync(cancellationToken);

                _dbContext.FoodItemPictures.RemoveRange(foodItemPicturesToDelete);


                var reviewsToDelete = await _dbContext.Reviews
                    .Where(r => r.RestaurantId == restaurantId)
                    .ToListAsync(cancellationToken);

                _dbContext.Reviews.RemoveRange(reviewsToDelete);

                var ordersToDelete = await _dbContext.Orders
                    .Where(o => o.RestaurantId == restaurantId)
                        .ToListAsync(cancellationToken);

                foreach (var order in ordersToDelete)
                {
                    var orderItemsToDelete = await _dbContext.OrderItems
                        .Where(oi => oi.OrderId == order.Id)
                        .ToListAsync(cancellationToken);
                    _dbContext.OrderItems.RemoveRange(orderItemsToDelete);
                }
                _dbContext.Orders.RemoveRange(ordersToDelete);



                var foodItemsToDelete = await _dbContext.FoodItems
                    .Include(fi => fi.SideDishes)
                    .Where(fi => fi.RestaurantId == restaurantId)
                    .ToListAsync(cancellationToken);

                foreach (var foodItem in foodItemsToDelete)
                {
                    _dbContext.SideDishes.RemoveRange(foodItem.SideDishes);
                }

                _dbContext.FoodItems.RemoveRange(foodItemsToDelete);




                var desktopRole = await _roleManager.FindByNameAsync("Desktop");
                if (desktopRole != null)
                {
                    var user = await _dbContext.Users
                        .Where(u => u.RestaurantId == restaurantId)
                        .FirstOrDefaultAsync(cancellationToken);

                    if (user != null)
                    {
                        var isDesktopUser = await _userManager.IsInRoleAsync(user, "Desktop");
                        if (isDesktopUser)
                        {
                            user.RestaurantId = null;
                            await _userManager.UpdateAsync(user);
                        }
                    }
                }

                var mobileDeliveryPersonRole = await _roleManager.FindByNameAsync("MOBILEDELIVERYPERSON");
                if (mobileDeliveryPersonRole != null)
                {
                    var mobileDeliveryPersonUsers = await _dbContext.Users
                        .Where(u => u.RestaurantId == restaurantId)
                        .ToListAsync(cancellationToken);

                    foreach (var user in mobileDeliveryPersonUsers)
                    {
                        var isMobileDeliveryPersonUser = await _userManager.IsInRoleAsync(user, "MOBILEDELIVERYPERSON");
                        if (isMobileDeliveryPersonUser)
                        {
                            user.RestaurantId = null;
                            await _userManager.UpdateAsync(user);
                        }
                    }
                }

                var restaurantProfilePhotoToDelete = await _dbContext.Images.Where(i => i.CreatedByUser.RestaurantId == restaurantId).FirstOrDefaultAsync();
                if (restaurantProfilePhotoToDelete != null)
                {
                    _dbContext.Images.Remove(restaurantProfilePhotoToDelete);
                }

                var restaurantToDelete = await _dbContext.Restaurants.FindAsync(restaurantId);
                if (restaurantToDelete != null)
                {
                    _dbContext.Restaurants.Remove(restaurantToDelete);
                }


                await _dbContext.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);

                return new Message
                {
                    IsValid = true,
                    Info = "Successfully deleted restaurant and related entities.",
                    Status = ExceptionCode.NoContent,
                };
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException;
                while (innerException != null)
                {

                    innerException = innerException.InnerException;
                    Console.WriteLine(innerException);
                }

                await transaction.RollbackAsync(cancellationToken);

                return new Message
                {
                    IsValid = false,
                    Info = ex.Message,
                    Status = ExceptionCode.BadRequest,
                };
            }
        }


        public async Task<Message> GetRestaurantByIdAsMessage(int RestaurantId, CancellationToken cancellationToken)
        {
            try
            {
                var restaurant = await _dbContext.Restaurants.Include(x => x.Logo).Include(x => x.Location).Include(x => x.Location.City)
                    .Include(x => x.Reviews).ThenInclude(r=>r.CreatedByUser).Include(x => x.CreatedByUser).AsNoTracking().Where(x => x.Id == RestaurantId).FirstOrDefaultAsync(cancellationToken);


                var obj = Mapper.Map<RestaurantGetVM>(restaurant);

                obj.Reviews = restaurant.Reviews.Select(r => new GetReviewVM
                {
                    Id = r.Id,
                    Grade = r.Grade,
                    Description = r.Description,
                    RestaurantId = r.RestaurantId,
                    UserName = r.CreatedByUser?.UserName, 
                    CreatedDate = r.CreatedDate 
                }).ToList();

                return new Message
                {
                    IsValid = true,
                    Info = "Successfully got restaurant",
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

        public async Task<Message> GetRestaurantsAsMessage(int cityId, CancellationToken cancellationToken, string? name, int? categoryId)
        {
            try
            {
                IQueryable<Restaurant> query = _dbContext.Restaurants
                   .Include(x => x.Location)
                   .Include(x => x.Logo)
                   .Include(x => x.Location.City)
                   //.Include(x => x.Reviews)
                   .Where(x => (cityId == null || cityId == x.Location.CityId));

                if (categoryId.HasValue)
                {

                    query = query.Where(r => _dbContext.FoodItems.Any(fi => fi.RestaurantId == r.Id && fi.CategoryId == categoryId.Value))

                       .Select(r => new { Restaurant = r, FoodItemCount = _dbContext.FoodItems.Count(fi => fi.RestaurantId == r.Id && fi.CategoryId == categoryId.Value) })
                       .OrderByDescending(r => r.FoodItemCount)
                       .Select(r => r.Restaurant);
                }

                if (!string.IsNullOrEmpty(name))
                {
                    query = query.Where(x => x.Name.StartsWith(name));
                }

                var obj = Mapper.Map<List<RestaurantGetVM>>(query);
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



        public async Task<Message> GetRestaurantsForAdminAsMessage(CancellationToken cancellationToken, int? cityId, string? name, int items_per_page = 10, int pageNumber = 1)
        {
            try
            {
                IQueryable<Restaurant> query = _dbContext.Restaurants
                    .Include(x => x.Location)
                    .Include(x => x.CreatedByUser)
                    .Include(x => x.Logo)
                    .Include(x => x.Location.City);

                if (cityId.HasValue)
                {
                    query = query.Where(x => x.Location.CityId == cityId.Value);
                }

                if (!string.IsNullOrEmpty(name))
                {
                    query = query.Where(x => x.Name.StartsWith(name));
                }

                var pagedRestaurants = await PagedList<Restaurant>.Create(query, pageNumber, items_per_page);

                var restaurantsVM = Mapper.Map<List<RestaurantGetVM>>(pagedRestaurants.DataItems);

                return new Message
                {
                    IsValid = true,
                    Info = "Successfully returned paginated and filtered restaurants",
                    Status = ExceptionCode.Success,
                    Data = new { Restaurants = restaurantsVM, pagedRestaurants.TotalPages, pagedRestaurants.TotalCount }
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
                var loggedUser = await _authContext.GetLoggedUser();

                var restaurant = await _dbContext.Restaurants.Include(x => x.Location)
                    .Include(x => x.Location.City).Where(x => x.Id == RestaurantId).FirstOrDefaultAsync(cancellationToken);
                Mapper.Map(restaurantUpdateVM, restaurant);
                restaurant.ModifiedByUserId = loggedUser.Id;
                restaurant.OpeningTime = TimeSpan.ParseExact(restaurantUpdateVM.OpeningTime, "hh\\:mm", CultureInfo.InvariantCulture);
                restaurant.ClosingTime = TimeSpan.ParseExact(restaurantUpdateVM.ClosingTime, "hh\\:mm", CultureInfo.InvariantCulture);


                await _dbContext.SaveChangesAsync(cancellationToken);

                return new Message
                {
                    IsValid = true,
                    Info = "Successfully updated restaurant",
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

        public async Task<Message> GetRestaurantEmployeesAsMessageAsync(CancellationToken cancellationToken, int items_per_page = 3, int pageNumber = 1, bool? isAvailable = null, string? username = null)
        {
            try
            {
                var loggedUser = await _authContext.GetLoggedUser();

                var query = _dbContext.Users
                    .Where(x => x.Id != loggedUser.Id && x.RestaurantId == loggedUser.RestaurantId)
                    .AsQueryable();

                // Apply filtering based on isAvailable
                if (isAvailable.HasValue)
                {
                    query = query.Where(x => x.IsAvailable == isAvailable);
                }

                // Apply filtering based on username if it is not empty
                if (!string.IsNullOrEmpty(username))
                {
                    var lowerUsername = username.ToLower();
                    query = query.Where(x => x.FirstName.ToLower().StartsWith(lowerUsername)
                                          || x.LastName.ToLower().StartsWith(lowerUsername));
                }

                // Ensure sorting is done here as per your requirements
                query = query.OrderBy(x => x.LastName).ThenBy(x => x.FirstName);

                // Ensure sorting is done here as per your requirements
                query = query.OrderBy(x => x.UserName);

                // Apply pagination after all filters
                var pagedEmployees = await PagedList<User>.Create(query, pageNumber, items_per_page);

                var employeesVM = Mapper.Map<List<UserGetVM>>(pagedEmployees.DataItems);

                return new Message
                {
                    IsValid = true,
                    Info = "Successfully returned data",
                    Status = ExceptionCode.Success,
                    Data = new { Employees = employeesVM, pagedEmployees.TotalPages, pagedEmployees.TotalCount }
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

        public async Task<Message> RemoveEmployeeFromRestaurantAsMessageAsync(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var employee = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
                if (employee == null)
                {
                    return new Message
                    {
                        IsValid = false,
                        Info = "Dostavljač nije pronađen.",
                        Status = ExceptionCode.NotFound // Consider using a 'NotFound' status if applicable
                    };
                }

                employee.RestaurantId = null;
                await _dbContext.SaveChangesAsync(cancellationToken); // Save changes asynchronously

                // Assuming SaveChangesAsync returns without throwing, the operation succeeded
                return new Message
                {
                    IsValid = true,
                    Info = "Uspješno uklonjen dostavljač.",
                    Status = ExceptionCode.Success
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    IsValid = false,
                    Info = $"Greška pri uklanjanju dostavljača: {ex.Message}",
                    Status = ExceptionCode.BadRequest
                };
            }
        }


        public async Task<Message> GetRecommendedRestaurantsAsMessageAsync(CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await _authContext.GetLoggedUser();

                var userOrders = await _dbContext.Orders
                    .Where(o => o.CreatedByUserId == loggedUser.Id)
                    .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.FoodItem)
                    .ThenInclude(fi => fi.Category)
                    .ToListAsync(cancellationToken);

                var categoryPreferences = new Dictionary<int, int>();

                foreach (var order in userOrders)
                {
                    foreach (var orderItem in order.OrderItems)
                    {
                        var categoryId = orderItem.FoodItem.CategoryId;
                        if (categoryPreferences.ContainsKey(categoryId))
                        {
                            categoryPreferences[categoryId]++;
                        }
                        else
                        {
                            categoryPreferences[categoryId] = 1;
                        }
                    }
                }

                var restaurants = await _dbContext.Restaurants
                    .Where(r => r.Location.CityId == loggedUser.CityId)
                    .Include(r => r.Reviews)
                    .Include(r => r.Location)
                    .Include(r => r.Logo)
                    .Include(r => r.CreatedByUser)
                    .ToListAsync(cancellationToken);

                var foodItems = await _dbContext.FoodItems
                    .Include(fi => fi.Category)
                    .ToListAsync(cancellationToken);

                var recommendedRestaurants = new List<RestaurantGetVM>();

                foreach (var restaurant in restaurants)
                {
                    var averageRating = restaurant.Reviews.Any() ? restaurant.Reviews.Average(r => r.Grade) : 0;
                    var restaurantFoodItems = foodItems.Where(fi => fi.RestaurantId == restaurant.Id);
                    var categoryPreferenceScore = restaurantFoodItems
                        .Count(fi => categoryPreferences.ContainsKey(fi.CategoryId));

                    var recommendationScore = (averageRating * 0.7) + (categoryPreferenceScore * 0.3);

                    recommendedRestaurants.Add(new RestaurantGetVM
                    {
                        Id = restaurant.Id,
                        Name = restaurant.Name,
                        Address = restaurant.Address,
                        IsOpen = restaurant.IsOpen,
                        OpeningTime = restaurant.OpeningTime,
                        ClosingTime = restaurant.ClosingTime,
                        ContactNumber = restaurant.ContactNumber,
                        DeliveryCharge = restaurant.DeliveryCharge,
                        DeliveryTime = restaurant.DeliveryTime,
                        Location = Mapper.Map<LocationGetVM>(restaurant.Location),
                        Logo = Mapper.Map<ImageGetVM>(restaurant.Logo),
                        Reviews = Mapper.Map<List<GetReviewVM>>(restaurant.Reviews),
                        CreatedByUser = Mapper.Map<UserGetVM>(restaurant.CreatedByUser)
                    });
                }

                recommendedRestaurants = recommendedRestaurants
                    .OrderByDescending(r => r.Reviews.Any() ? r.Reviews.Average(review => review.Grade) : 0)
                    .Take(3)
                    .ToList();

                return new Message
                {
                    IsValid = true,
                    Info = "Successfully retrieved recommended restaurants",
                    Status = ExceptionCode.Success,
                    Data = recommendedRestaurants
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


        public async Task<Message> GetRecommendedRestaurants()
        {
            var loggedInUser = await _authContext.GetLoggedUser();
            var userOrders = await _dbContext.Orders
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.FoodItem)
                        .ThenInclude(fi => fi.Category)
                .Where(o => o.CreatedByUserId == loggedInUser.Id)
                .ToListAsync();

            var userCategoryPreferences = userOrders
                .SelectMany(o => o.OrderItems)
                .GroupBy(oi => oi.FoodItem.CategoryId)
                .ToDictionary(g => g.Key, g => g.Count());

            var mlContext = new MLContext();

            var restaurantData =  _dbContext.Restaurants
                .Include(r => r.Reviews)
                .Where(r => r.Location.CityId == loggedInUser.CityId)
                .Select(r => new
                {
                    RestaurantId = r.Id,
                    Rating = r.Reviews.Any() ? r.Reviews.Average(rev => rev.Grade) : 0,
                    FoodItems = _dbContext.FoodItems.Where(fi => fi.RestaurantId == r.Id).ToList()
                })
                .AsEnumerable()
                .Select(r => new RestaurantRatingData
                {
                    RestaurantId = r.RestaurantId,
                    Rating = r.Rating,
                    CategoryCounts = r.FoodItems
                        .GroupBy(fi => fi.CategoryId)
                        .ToDictionary(g => g.Key, g => g.Count())
                })
                .ToList();

            var trainingData = restaurantData
                .SelectMany(r => userCategoryPreferences
                    .Select(ucp => new RestaurantRating
                    {
                        RestaurantId = r.RestaurantId,
                        CategoryId = ucp.Key,
                        Rating = ((float)(r.CategoryCounts.TryGetValue(ucp.Key, out var count)
                            ? count * r.Rating
                            : 0))
                    }))
                .ToList();

            var dataView = mlContext.Data.LoadFromEnumerable(trainingData);

            var pipeline = mlContext.Transforms
            .Conversion.MapValueToKey(inputColumnName: nameof(RestaurantRating.RestaurantId), outputColumnName: "RestaurantIdEncoded")
            .Append(mlContext.Transforms.Conversion.MapValueToKey(inputColumnName: nameof(RestaurantRating.CategoryId), outputColumnName: "CategoryIdEncoded"))
            .Append(mlContext.Recommendation().Trainers.MatrixFactorization(
                 labelColumnName: nameof(RestaurantRating.Rating),
                 matrixColumnIndexColumnName: "RestaurantIdEncoded",
                 matrixRowIndexColumnName: "CategoryIdEncoded"));


            var model = pipeline.Fit(dataView);

            var predictionEngine = mlContext.Model
                .CreatePredictionEngine<RestaurantRating, RestaurantRatingPrediction>(model);

            var recommendedRestaurants = restaurantData
                .Select(r => new
                {
                    Restaurant = r,
                    Prediction = predictionEngine.Predict(
                        new RestaurantRating
                        {
                            RestaurantId = r.RestaurantId,
                            CategoryId = userCategoryPreferences.OrderByDescending(ucp => ucp.Value).First().Key
                        })
                })
                .OrderByDescending(r => r.Prediction.Score)
                .Select(r => Mapper.Map<RestaurantGetVM>(_dbContext.Restaurants.Include(r=>r.Logo).First(res => res.Id == r.Restaurant.RestaurantId)))
                .Take(3)
                .ToList();

            return new Message
            {
                Status = ExceptionCode.Success,
                Info = "Recommended restaurants retrieved successfully.",
                Data = recommendedRestaurants,
                IsValid = true
            };
        }



        public class RestaurantRatingData
        {
            public int RestaurantId { get; set; }
            public double Rating { get; set; }
            public Dictionary<int, int> CategoryCounts { get; set; }
        }

        public class RestaurantRating
        {
            public int RestaurantId { get; set; }
            public int CategoryId { get; set; }
            public float Rating { get; set; }
        }

        public class RestaurantRatingPrediction
        {
            public float Score { get; set; }
        }


    }
}
