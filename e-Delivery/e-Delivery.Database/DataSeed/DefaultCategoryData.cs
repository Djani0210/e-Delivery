using e_Delivery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Database.DataSeed
{
    public class DefaultCategoryData
    {

        public static IEnumerable<Category> Categories
        {
            get => new List<Category>()
            {
                new Category
                {
                    Id = 1,
                    Name = "Burger",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                },
                new Category
                {
                    Id = 2,
                    Name = "Pizza",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                },
                new Category
                {
                    Id = 3,
                    Name = "Pasta",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                },
                new Category
                {
                    Id = 4,
                    Name = "Sea Food",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                },
                new Category
                {
                    Id = 5,
                    Name = "Grill",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                },
                new Category
                {
                    Id = 6,
                    Name = "Vegetarian",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                },
                new Category
                {
                    Id = 7,
                    Name = "Vegan",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                },
                new Category
                {
                    Id = 8,
                    Name = "Sandwich",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                },
                new Category
                {
                    Id = 9,
                    Name = "Cooked dishes",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                },
                new Category
                {
                    Id = 10,
                    Name = "Cakes",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                },
                new Category
                {
                    Id = 11,
                    Name = "Pancakes",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                },
            };
        }
    }
}
