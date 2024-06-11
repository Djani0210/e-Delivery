using e_Delivery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Database.DataSeed
{
    public class DefaultNotificationData
    {
        public static IEnumerable<Notification> Notifications
        {
            get => new List<Notification>
            {
                new Notification
                {
                    Id = 1,
                    Content = "Your order has been delivered.",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    SentByUserId = Guid.Parse("B8396F1D-A29A-4856-A4C1-1312DC97A4A1"), 
                    SentToUserId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                    RestaurantName = "Aldi - Caffe slastičarna"
                },
                new Notification
                {
                    Id = 2,
                    Content = "Your order has been delivered.",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    SentByUserId = Guid.Parse("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"), 
                    SentToUserId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045"), 
                    RestaurantName = "Aldi - Caffe slastičarna"
                },
                 new Notification
                {
                    Id = 3,
                    Content = "Your order has been delivered.",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    SentByUserId = Guid.Parse("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"),
                    SentToUserId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                    RestaurantName = "Aldi - Caffe slastičarna"
                },
                  new Notification
                {
                    Id = 4,
                    Content = "You have been assigned to an order.",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    SentByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                    SentToUserId = Guid.Parse("B8396F1D-A29A-4856-A4C1-1312DC97A4A1"),
                    RestaurantName = "Aldi - Caffe slastičarna"
                },


            };
        }
    }
}
