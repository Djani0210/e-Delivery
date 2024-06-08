using AutoMapper;
using e_Delivery.Database;
using e_Delivery.Entities;
using e_Delivery.Entities.Enums;
using e_Delivery.Model.Review;
using e_Delivery.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Services
{
    public class ReviewService : IReviewService
    {
        public readonly eDeliveryDBContext _dbContext;
        public IMapper Mapper { get; set; }
        private IAuthContext authContext { get; set; }

        public ReviewService(eDeliveryDBContext dbContext, IMapper mapper, IAuthContext AuthContext)
        {
            _dbContext = dbContext;
            Mapper = mapper;
            authContext = AuthContext;
        }
        public async Task<Message> CreateOrUpdateReviewAsMessageAsync(CreateOrUpdateReviewVM createOrUpdateReviewVM, CancellationToken cancellationToken)
        {
            try
            {
                if (!(createOrUpdateReviewVM.Grade >= 1 && createOrUpdateReviewVM.Grade <= 5))
                {
                    return new Message
                    {
                        IsValid = false,
                        Info = "Your input is out of rating range",
                        Status = ExceptionCode.BadRequest
                    };
                }
                var restaurant = await _dbContext.Restaurants.FindAsync(createOrUpdateReviewVM.RestaurantId);

                if (restaurant == null)
                {
                    return new Message
                    {
                        IsValid = false,
                        Info = "Restaurant not found",
                        Status = ExceptionCode.NotFound
                    };
                }

                var user = await authContext.GetLoggedUser();
                if (user == null)
                {
                    return new Message
                    {
                        IsValid = false,
                        Info = "User is not logged in",
                        Status = ExceptionCode.Unauthorized
                    };
                }

                var orderExists = await _dbContext.Orders
                .AnyAsync(o => o.CreatedByUserId == user.Id && o.RestaurantId == createOrUpdateReviewVM.RestaurantId);

                if (!orderExists)
                {
                    return new Message
                    {
                        IsValid = false,
                        Info = "You cannot rate this restaurant because you haven't made any orders from it",
                        Status = ExceptionCode.Forbidden
                    };
                }
                var existingReview = await _dbContext.Reviews
                .FirstOrDefaultAsync(r => r.CreatedByUserId == user.Id && r.RestaurantId == createOrUpdateReviewVM.RestaurantId);


                if (existingReview == null)
                {
                    var obj = Mapper.Map<Entities.Review>(createOrUpdateReviewVM);
                    obj.CreatedDate = DateTime.Now;
                    obj.CreatedByUserId = user.Id;

                    _dbContext.Reviews.AddAsync(obj);
                }
                else
                {
                    existingReview.Grade = createOrUpdateReviewVM.Grade;
                    existingReview.Description = createOrUpdateReviewVM.Description;
                    existingReview.CreatedDate = DateTime.Now;
                    existingReview.ModifiedByUserId = user.Id;

                }
                await _dbContext.SaveChangesAsync(cancellationToken);

                return new Message
                {
                    IsValid = true,
                    Info = existingReview == null ? "Created review." : "Updated review.",
                    Status = ExceptionCode.Success,
                    Data = null
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    IsValid = false,
                    Info = ex.Message,
                    Status = ExceptionCode.Success
                };
            }
        }

        public async Task<Message> DeleteReviewAsMessageAsync(int id, CancellationToken cancellationToken)
        {
            Entities.Review? entity = await _dbContext.Reviews.FindAsync(id);
            if (entity is null)
            {
                return new Message
                {
                    Status = ExceptionCode.NotFound,
                    Info = "Entity not found",
                    IsValid = false
                };
            }
            _dbContext.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return new Message
            {
                Status = ExceptionCode.NoContent,
                Info = "Review successfully deleted",
                IsValid = true
            };
        }

        public async Task<double?> GetReviewScoreForRestaurantAsync(CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await authContext.GetLoggedUser();
                var restaurant = await _dbContext.Restaurants
                    .Include(r => r.Reviews)
                    .FirstOrDefaultAsync(r => r.Id == loggedUser.RestaurantId);

                if (restaurant != null && restaurant.Reviews.Any())
                {
                    double averageScore = restaurant.Reviews.Average(review => review.Grade);
                    return averageScore;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<double?> GetReviewScoreForRestaurantMobileAsync(int id, CancellationToken cancellationToken)
        {
            try
            {

                var restaurant = await _dbContext.Restaurants
                    .Include(r => r.Reviews)
                    .FirstOrDefaultAsync(r => r.Id == id);

                if (restaurant != null && restaurant.Reviews.Any())
                {
                    double averageScore = restaurant.Reviews.Average(review => review.Grade);
                    return averageScore;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
