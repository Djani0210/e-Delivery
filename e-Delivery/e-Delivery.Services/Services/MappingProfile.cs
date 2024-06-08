using AutoMapper;
using e_Delivery.Entities;
using e_Delivery.Model.Category;
using e_Delivery.Model.Chat;
using e_Delivery.Model.City;
using e_Delivery.Model.FoodItem;
using e_Delivery.Model.Images;
using e_Delivery.Model.Location;
using e_Delivery.Model.Notification;
using e_Delivery.Model.Order;
using e_Delivery.Model.Restaurant;
using e_Delivery.Model.Review;
using e_Delivery.Model.Role;
using e_Delivery.Model.SideDish;
using e_Delivery.Model.User;
using e_Delivery.Model.Verification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //================USERS===================
            CreateMap<UserCreateVM, User>();
            CreateMap<UserUpdateVM, User>();
            CreateMap<User, UserGetVM>();
            CreateMap<User, CustomerGetVM>();
            CreateMap<User, DeliveryPersonGetVM>();
            //========================================


            //================ROLES===================
            CreateMap<RoleCreateVM, Role>();
            //========================================

            //================VERIFICATIONS===========
            CreateMap<Verification, VerificationGetVM>();
            //========================================

            //================CITIES==================
            CreateMap<CityCreateVM, City>();
            CreateMap<City, CityGetVM>();
            //========================================

            //================Categories==================
            CreateMap<CategoryCreateVM, Category>();
            CreateMap<Category, CategoriesGetVM>();
            CreateMap<Category, CategoriesWithFoodItemsGetVM>();
            //========================================

            //================IMAGES==================
            CreateMap<ImageCreateVM, Image>();
            CreateMap<Image, ImageGetVM>();
            //========================================


            //================LOCATIONS===============
            CreateMap<LocationCreateVM, Location>();
            CreateMap<LocationUpdateVM, Location>();
            CreateMap<Location, LocationGetVM>();
            //========================================

            //================SIDEDISHES===============
            CreateMap<CreateSideDishVM, SideDish>();
            CreateMap<UpdateSideDishVM, SideDish>();
            CreateMap<SideDish, GetSideDishVM>();
            //========================================

            //================FOODITEMS===============
            CreateMap<CreateFoodItemVM, FoodItem>();
            CreateMap<UpdateFoodItemVM, FoodItem>();
            CreateMap<FoodItem, FoodItemGetVM>();
            //.ForMember(dest => dest.FoodItemPictures, opt => opt.MapFrom(src => src.FoodItemPictures));
            CreateMap<FoodItemPictures, FoodItemPictureGetVM>();

            //================RESTAURANTS===============
            CreateMap<RestaurantCreateVM, Restaurant>();
            CreateMap<RestaurantUpdateVM, Restaurant>();
            CreateMap<Restaurant, RestaurantGetVM>();

            //================ORDERS===============
            CreateMap<CreateOrderVM, Order>();
            CreateMap<UpdateOrderVM, Order>();
            CreateMap<Order, GetOrderVM>();
            CreateMap<OrderItem, GetOrderItemVM>();
            CreateMap<OrderItemVM, OrderItem>()
             .ForMember(dest => dest.SideDishIds, opt => opt.MapFrom(src => src.SideDishIds));

            //================REVIEWS===============
            CreateMap<CreateOrUpdateReviewVM, Review>();
            CreateMap<Review, GetReviewVM>();

            //================NOTIFICATIONS===============
            CreateMap<Notification, GetNotificationVM>();

            //================CHATS===============
            CreateMap<Chat,ChatDto>();
        }
    }
}
