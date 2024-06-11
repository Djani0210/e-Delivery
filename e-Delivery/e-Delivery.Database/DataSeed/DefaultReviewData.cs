using e_Delivery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Database.DataSeed
{
    public class DefaultReviewData
    {
        public static IEnumerable<Review> Reviews
        {
            get => new List<Review>
            {

                //RESTAURANT ID = 1
                new Review
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    CreatedByUserId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                    ModifiedByUserId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                    Grade = 5.00,
                    Description = "Great food!",
                    RestaurantId = 1
                },
                new Review
                {
                    Id = 2,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    CreatedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                    ModifiedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                    Grade = 4.5,
                    Description = "Very good food!",
                    RestaurantId = 1
                },
                new Review
                {
                    Id = 3,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    CreatedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                    ModifiedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                    Grade = 4.0,
                    Description = "Solid food!",
                    RestaurantId = 1
                },

                //RESTAURANT ID = 2
                new Review
                {
                    Id = 4,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    CreatedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                    ModifiedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                    Grade = 4.5,
                    Description = "Very good food!",
                    RestaurantId = 2
                },
                new Review
                {
                    Id = 5,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    CreatedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                    ModifiedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                    Grade = 4.0,
                    Description = "Solid food!",
                    RestaurantId = 2
                },

                 //RESTAURANT ID = 3
                new Review
                {
                    Id = 6,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    CreatedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                    ModifiedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                    Grade = 5.00,
                    Description = "Very good food!",
                    RestaurantId = 3
                },
                new Review
                {
                    Id = 7,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    CreatedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                    ModifiedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                    Grade = 4.50,
                    Description = "Solid food!",
                    RestaurantId = 3
                },
                 //Restaurant Id = 4
                 new Review
                {
                    Id = 8,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    CreatedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                    ModifiedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                    Grade = 3.50,
                    Description = "Very good food!",
                    RestaurantId = 4
                },

                new Review
                {
                    Id = 9,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    CreatedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                    ModifiedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                    Grade = 4.00,
                    Description = "Solid food!",
                    RestaurantId = 4
                },
                //Restaurant Id = 5
                 new Review
                {
                    Id = 10,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    CreatedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                    ModifiedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                    Grade = 4.50,
                    Description = "Very good food!",
                    RestaurantId = 5
                },

                new Review
                {
                    Id = 11,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    CreatedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                    ModifiedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                    Grade = 2.00,
                    Description = "Solid food!",
                    RestaurantId = 5
                },
                //Restaurant Id = 6
                 new Review
                {
                    Id = 12,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    CreatedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                    ModifiedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                    Grade = 2.50,
                    Description = "Very good food!",
                    RestaurantId = 6
                },

                new Review
                {
                    Id = 13,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    CreatedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                    ModifiedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                    Grade = 3.00,
                    Description = "Solid food!",
                    RestaurantId = 6
                },
            };
        }
    }
}
