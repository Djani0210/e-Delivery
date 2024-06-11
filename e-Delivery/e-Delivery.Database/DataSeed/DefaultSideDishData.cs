using e_Delivery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Database.DataSeed
{
    public class DefaultSideDishData
    {
        public static IEnumerable<SideDish> SideDishes
        {
            get => new List<SideDish>()
        {
            new SideDish
            {
                Id = 1,
                Name = "Mayonnaise",
                Price = 1.00,
                IsAvailable = true,
                RestaurantId = 1
            },
            new SideDish
            {
                Id = 2,
                Name = "Ketchup",
                Price = 1.00,
                IsAvailable = true,
                RestaurantId = 1
            },
            new SideDish
            {
                Id = 3,
                Name = "Tartar sauce",
                Price = 1.00,
                IsAvailable = true,
                RestaurantId = 1
            },
            new SideDish
            {
                Id = 4,
                Name = "French fries",
                Price = 2.50,
                IsAvailable = true,
                RestaurantId = 1
            },
            new SideDish
            {
                Id = 5,
                Name = "Extra cheese",
                Price = 1.50,
                IsAvailable = true,
                RestaurantId = 1
            },
            new SideDish
            {
                Id = 6,
                Name = "Ice cream",
                Price = 2.00,
                IsAvailable = true,
                RestaurantId = 1
            },
            new SideDish
            {
                Id = 7,
                Name = "Mayonnaise",
                Price = 1.00,
                IsAvailable = true,
                RestaurantId = 2
            },
            new SideDish
            {
                Id = 8,
                Name = "Ketchup",
                Price = 1.00,
                IsAvailable = true,
                RestaurantId = 2
            },
            new SideDish
            {
                Id = 9,
                Name = "Tartar sauce",
                Price = 1.00,
                IsAvailable = true,
                RestaurantId = 2
            },
            new SideDish
            {
                Id = 10,
                Name = "Cream",
                Price = 0.50,
                IsAvailable = true,
                RestaurantId = 2
            },
            new SideDish
            {
                Id = 11,
                Name = "French fries",
                Price = 2.50,
                IsAvailable = true,
                RestaurantId = 3
            },
            new SideDish
            {
                Id = 12,
                Name = "Mayonnaise",
                Price = 1.50,
                IsAvailable = true,
                RestaurantId = 3
            },
            new SideDish
            {
                Id = 13,
                Name = "Ketchup",
                Price = 1.50,
                IsAvailable = true,
                RestaurantId = 3
            },
            new SideDish
            {
                Id = 14,
                Name = "Ajvar",
                Price = 1.50,
                IsAvailable = true,
                RestaurantId = 3
            },
            new SideDish
            {
                Id = 15,
                Name = "Barbecue sauce",
                Price = 2.50,
                IsAvailable = true,
                RestaurantId = 3
            },
            new SideDish
            {
                Id = 16,
                Name = "Soy sauce",
                Price = 2.00,
                IsAvailable = true,
                RestaurantId = 3
            },
            new SideDish
            {
                Id = 17,
                Name = "Vinegar",
                Price = 2.00,
                IsAvailable = true,
                RestaurantId = 3
            },
            new SideDish
            {
                Id = 18,
                Name = "Hot sauce",
                Price = 2.00,
                IsAvailable = true,
                RestaurantId = 3
            },
            new SideDish
            {
                Id = 19,
                Name = "Prosciutto",
                Price = 2.50,
                IsAvailable = true,
                RestaurantId = 4
            },
            new SideDish
            {
                Id = 20,
                Name = "Kajmak",
                Price = 1.50,
                IsAvailable = true,
                RestaurantId = 4
            },
            new SideDish
            {
                Id = 21,
                Name = "Sour cream",
                Price = 1.50,
                IsAvailable = true,
                RestaurantId = 4
            },
            new SideDish
            {
                Id = 22,
                Name = "Mayonaisse",
                Price = 1.50,
                IsAvailable = true,
                RestaurantId = 5
            },
            new SideDish
            {
                Id = 23,
                Name = "Ketchup",
                Price = 1.50,
                IsAvailable = true,
                RestaurantId = 5
            },
            new SideDish
            {
                Id = 24,
                Name = "Tartar sauce",
                Price = 1.50,
                IsAvailable = true,
                RestaurantId = 5
            },
            new SideDish
            {
                Id = 25,
                Name = "Ice cream",
                Price = 1.50,
                IsAvailable = true,
                RestaurantId = 5
            },
            new SideDish
            {
                Id = 26,
                Name = "Whipped cream",
                Price = 0.50,
                IsAvailable = true,
                RestaurantId = 5
            },
            new SideDish
            {
                Id = 27,
                Name = "Vinegar",
                Price = 1.50,
                IsAvailable = true,
                RestaurantId = 5
            },
            new SideDish
            {
                Id = 28,
                Name = "Vinegar",
                Price = 1.50,
                IsAvailable = true,
                RestaurantId = 6
            },
            new SideDish
            {
                Id = 29,
                Name = "Mayonnaise",
                Price = 1.50,
                IsAvailable = true,
                RestaurantId = 6
            },
            new SideDish
            {
                Id = 30,
                Name = "Ketchup",
                Price = 1.50,
                IsAvailable = true,
                RestaurantId = 6
            },
            new SideDish
            {
                Id = 31,
                Name = "Extra cheese",
                Price = 1.50,
                IsAvailable = true,
                RestaurantId = 6
            },

        };
        }
    }

}
