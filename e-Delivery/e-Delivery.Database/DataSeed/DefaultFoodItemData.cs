using e_Delivery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Database.DataSeed
{
    public class DefaultFoodItemData
    {
        public static IEnumerable<FoodItem> FoodItems
        {
            get => new List<FoodItem>()
        {
            new FoodItem
            {
                Id = 1,
                Name = "Hamburger",
                Description = "Juicy beef patty with tomato, salad, onions",
                Price = 9.00,
                IsAvailable = true,
                CategoryId = 1,
                RestaurantId = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                ModifiedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b")
            },
            new FoodItem
            {
                Id = 2,
                Name = "Cheeseburger",
                Description = "Juicy beef patty with tomato, salad, onions and cheese",
                Price = 11.00,
                IsAvailable = true,
                CategoryId = 1,
                RestaurantId = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                ModifiedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b")
            },
            new FoodItem
            {
                Id = 3,
                Name = "Margarita",
                Description = "Regular pizza with Gauda cheese",
                Price = 9.00,
                IsAvailable = true,
                CategoryId = 2,
                RestaurantId = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                ModifiedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b")
            },
            new FoodItem
            {
                Id = 4,
                Name = "Capricciosa",
                Description = "Pizza with salami and mushrooms",
                Price = 11.00,
                IsAvailable = true,
                CategoryId = 2,
                RestaurantId = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false
                ,
                CreatedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                ModifiedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b")
            },
            new FoodItem
            {
                Id = 5,
                Name = "Funghi",
                Description = "Pizza with mushrooms",
                Price = 10.00,
                IsAvailable = true,
                CategoryId = 2,
                RestaurantId = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false
                ,
                CreatedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                ModifiedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b")
            },
            new FoodItem
            {
                Id = 6,
                Name = "Chicken fillet",
                Description = "Grilled chicken 100g",
                Price = 9.00,
                IsAvailable = true,
                CategoryId = 5,
                RestaurantId = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                ModifiedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b")
            },
            new FoodItem
            {
                Id = 7,
                Name = "Sausages",
                Description = "Lamb sausages 100g",
                Price = 9.00,
                IsAvailable = true,
                CategoryId = 5,
                RestaurantId = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                ModifiedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b")
            },
            new FoodItem
            {
                Id = 8,
                Name = "Classic sandwich",
                Description = "Salami-cheese sandwich with tomato, lettuce and onions",
                Price = 9.00,
                IsAvailable = true,
                CategoryId = 8,
                RestaurantId = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                ModifiedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b")
            },
            new FoodItem
            {
                Id = 9,
                Name = "Chicken sandwich",
                Description = "Chicken sandwich with tomato, lettuce and onions",
                Price = 10.00,
                IsAvailable = true,
                CategoryId = 8,
                RestaurantId = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                ModifiedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b")
            },
            new FoodItem
            {
                Id = 10,
                Name = "Pepperoni sandwich",
                Description = "Pepperoni sandwich with tomato, lettuce and onions",
                Price = 10.00,
                IsAvailable = true,
                CategoryId = 8,
                RestaurantId = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                ModifiedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b")
            },
            new FoodItem
            {
                Id = 11,
                Name = "Sacher-Torte",
                Description = "Homemade chocolate cake, original recipe",
                Price = 4.00,
                IsAvailable = true,
                CategoryId = 10,
                RestaurantId = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                ModifiedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b")
            },
            new FoodItem
            {
                Id = 12,
                Name = "Baklava",
                Description = "Homemade baklava, original recipe",
                Price = 4.00,
                IsAvailable = true,
                CategoryId = 10,
                RestaurantId = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                ModifiedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b")
            },
            new FoodItem
            {
                Id = 13,
                Name = "Nutella pancakes",
                Description = "Nutella filled pancakakes",
                Price = 7.00,
                IsAvailable = true,
                CategoryId = 11,
                RestaurantId = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                ModifiedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b")
            },
            new FoodItem
            {
                Id = 14,
                Name = "Jam pancakes",
                Description = "Strawberry jam filled pancakakes",
                Price = 6.00,
                IsAvailable = true,
                CategoryId = 11,
                RestaurantId = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                ModifiedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b")
            },
            new FoodItem
            {
                Id = 15,
                Name = "Margarita",
                Description = "Regular pizza with cheese",
                Price = 8.00,
                IsAvailable = true,
                CategoryId = 2,
                RestaurantId = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                ModifiedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310")
            },
            new FoodItem
            {
                Id = 16,
                Name = "Capricciosa",
                Description = "Pizza with salami and mushrooms",
                Price = 10.00,
                IsAvailable = true,
                CategoryId = 2,
                RestaurantId = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                ModifiedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310")
            },
            new FoodItem
            {
                Id = 17,
                Name = "Funghi",
                Description = "Pizza with mushrooms",
                Price = 9.00,
                IsAvailable = true,
                CategoryId = 2,
                RestaurantId = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                ModifiedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310")
            },
            new FoodItem
            {
                Id = 18,
                Name = "Pepperoni",
                Description = "Pizza with pepperoni sausage",
                Price = 11.00,
                IsAvailable = true,
                CategoryId = 2,
                RestaurantId = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                ModifiedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310")
            },
            new FoodItem
            {
                Id = 19,
                Name = "Chicken fillets",
                Description = "Chicken grilled fillets 100g",
                Price = 9.00,
                IsAvailable = true,
                CategoryId = 5,
                RestaurantId = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                ModifiedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310")
            },
            new FoodItem
            {
                Id = 20,
                Name = "ćevapi small portion",
                Description = "5 ćevapi with bread and onions",
                Price = 5.00,
                IsAvailable = true,
                CategoryId = 5,
                RestaurantId = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                ModifiedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310")
            },
            new FoodItem
            {
                Id = 21,
                Name = "ćevapi large portion",
                Description = "10 ćevapi with bread and onions",
                Price = 9.00,
                IsAvailable = true,
                CategoryId = 5,
                RestaurantId = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                ModifiedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310")
            },
            new FoodItem
            {
                Id = 22,
                Name = "Greek salad",
                Description = "",
                Price = 6.00,
                IsAvailable = true,
                CategoryId = 6,
                RestaurantId = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                ModifiedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310")
            },
            new FoodItem
            {
                Id = 23,
                Name = "Tomato salad",
                Description = "Tomato and onions",
                Price = 4.00,
                IsAvailable = true,
                CategoryId = 7,
                RestaurantId = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                ModifiedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310")
            },
            new FoodItem
            {
                Id = 24,
                Name = "Regular salad",
                Description = "Lettuce, tomato and onions",
                Price = 4.00,
                IsAvailable = true,
                CategoryId = 7,
                RestaurantId = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                ModifiedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310")
            },
            new FoodItem
            {
                Id = 25,
                Name = "Classic sandwich ",
                Description = "Salami and cheese with lettuce, tomato and onions",
                Price = 6.00,
                IsAvailable = true,
                CategoryId = 8,
                RestaurantId = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                ModifiedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310")
            },
            new FoodItem
            {
                Id = 26,
                Name = "Chicken sandwich ",
                Description = "Chicken and cheese with lettuce, tomato and onions",
                Price = 7.50,
                IsAvailable = true,
                CategoryId = 8,
                RestaurantId = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                ModifiedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310")
            },
            new FoodItem
            {
                Id = 27,
                Name = "Nutella pancakes ",
                Description = "Pancakes filled with nutella",
                Price = 7.00,
                IsAvailable = true,
                CategoryId = 11,
                RestaurantId = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                ModifiedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310")
            },
            new FoodItem
            {
                Id = 28,
                Name = "Stuffed squid",
                Description = "",
                Price = 15.00,
                IsAvailable = true,
                CategoryId = 4,
                RestaurantId = 3,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621"),
                ModifiedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621")
            },
            new FoodItem
            {
                Id = 29,
                Name = "Fried squid",
                Description = "",
                Price = 15.00,
                IsAvailable = true,
                CategoryId = 4,
                RestaurantId = 3,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621"),
                ModifiedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621")
            },
            new FoodItem
            {
                Id = 30,
                Name = "Neretvan trout filled",
                Description = "Filled with cream",
                Price = 15.00,
                IsAvailable = true,
                CategoryId = 4,
                RestaurantId = 3,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621"),
                ModifiedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621")
            },
            new FoodItem
            {
                Id = 31,
                Name = "Neretvan trout",
                Description = "",
                Price = 13.00,
                IsAvailable = true,
                CategoryId = 4,
                RestaurantId = 3,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621"),
                ModifiedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621")
            },
            new FoodItem
            {
                Id = 32,
                Name = "Beefsteak",
                Description = "",
                Price = 20.00,
                IsAvailable = true,
                CategoryId = 5,
                RestaurantId = 3,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621"),
                ModifiedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621")
            },
            new FoodItem
            {
                Id = 33,
                Name = "Chicken skewers small",
                Description = "",
                Price = 6.00,
                IsAvailable = true,
                CategoryId = 5,
                RestaurantId = 3,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621"),
                ModifiedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621")
            },
            new FoodItem
            {
                Id = 34,
                Name = "Chicken skewers large",
                Description = "",
                Price = 10.00,
                IsAvailable = true,
                CategoryId = 5,
                RestaurantId = 3,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621"),
                ModifiedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621")
            },
            new FoodItem
            {
                Id = 35,
                Name = "Ćevapi (small)",
                Description = "",
                Price = 5.00,
                IsAvailable = true,
                CategoryId = 5,
                RestaurantId = 3,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621"),
                ModifiedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621")
            },
            new FoodItem
            {
                Id = 36,
                Name = "Ćevapi (large)",
                Description = "",
                Price = 9.00,
                IsAvailable = true,
                CategoryId = 5,
                RestaurantId = 3,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621"),
                ModifiedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621")
            },
            new FoodItem
            {
                Id = 37,
                Name = "Green salad",
                Description = "",
                Price = 3.00,
                IsAvailable = true,
                CategoryId = 7,
                RestaurantId = 3,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621"),
                ModifiedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621")
            },
            new FoodItem
            {
                Id = 38,
                Name = "Tomato salad",
                Description = "",
                Price = 3.00,
                IsAvailable = true,
                CategoryId = 7,
                RestaurantId = 3,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621"),
                ModifiedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621")
            },
            new FoodItem
            {
                Id = 39,
                Name = "Salad with cheese",
                Description = "",
                Price = 4.00,
                IsAvailable = true,
                CategoryId = 6,
                RestaurantId = 3,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621"),
                ModifiedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621")
            },
            new FoodItem
            {
                Id = 40,
                Name = "Nutella pancakes",
                Description = "",
                Price = 6.00,
                IsAvailable = true,
                CategoryId = 11,
                RestaurantId = 3,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621"),
                ModifiedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621")
            },
            new FoodItem
            {
                Id = 41,
                Name = "Baklava",
                Description = "",
                Price = 4.00,
                IsAvailable = true,
                CategoryId = 10,
                RestaurantId = 3,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621"),
                ModifiedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621")
            },
            new FoodItem
            {
                Id = 42,
                Name = "Ćevapi (small)",
                Description = "",
                Price = 5.00,
                IsAvailable = true,
                CategoryId = 5,
                RestaurantId = 4,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f"),
                ModifiedByUserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f")
            },
            new FoodItem
            {
                Id = 43,
                Name = "Ćevapi (large)",
                Description = "",
                Price = 9.00,
                IsAvailable = true,
                CategoryId = 5,
                RestaurantId = 4,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f"),
                ModifiedByUserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f")
            },
            new FoodItem
            {
                Id = 44,
                Name = "Chicken fillets",
                Description = "",
                Price = 6.00,
                IsAvailable = true,
                CategoryId = 5,
                RestaurantId = 4,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f"),
                ModifiedByUserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f")
            },
            new FoodItem
            {
                Id = 45,
                Name = "Nutella pancakes",
                Description = "",
                Price = 6.00,
                IsAvailable = true,
                CategoryId = 11,
                RestaurantId = 4,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f"),
                ModifiedByUserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f")
            },
            new FoodItem
            {
                Id = 46,
                Name = "Baklava",
                Description = "",
                Price = 4.00,
                IsAvailable = true,
                CategoryId = 10,
                RestaurantId = 4,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f"),
                ModifiedByUserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f")
            },
            new FoodItem
            {
                Id = 47,
                Name = "Dolma",
                Description = "",
                Price = 8.00,
                IsAvailable = true,
                CategoryId = 9,
                RestaurantId = 4,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f"),
                ModifiedByUserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f")
            },
            new FoodItem
            {
                Id = 48,
                Name = "Japrak",
                Description = "",
                Price = 7.00,
                IsAvailable = true,
                CategoryId = 9,
                RestaurantId = 4,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f"),
                ModifiedByUserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f")
            },
            new FoodItem
            {
                Id = 49,
                Name = "Biber meso",
                Description = "",
                Price = 8.50,
                IsAvailable = true,
                CategoryId = 9,
                RestaurantId = 4,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f"),
                ModifiedByUserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f")
            },
            new FoodItem
            {
                Id = 50,
                Name = "Bosnian pot",
                Description = "",
                Price = 7.00,
                IsAvailable = true,
                CategoryId = 9,
                RestaurantId = 4,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f"),
                ModifiedByUserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f")
            },
            new FoodItem
            {
                Id = 51,
                Name = "Hamburger",
                Description = "Juicy beef patty with tomato, salad, onions",
                Price = 9.00,
                IsAvailable = true,
                CategoryId = 1,
                RestaurantId = 5,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                ModifiedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39")
            },
            new FoodItem
            {
                Id = 52,
                Name = "Cheeseburger",
                Description = "Juicy beef patty with tomato, salad, onions and cheese",
                Price = 11.00,
                IsAvailable = true,
                CategoryId = 1,
                RestaurantId = 5,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                ModifiedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39")
            },
            new FoodItem
            {
                Id = 53,
                Name = "Margarita",
                Description = "Regular pizza with Gauda cheese",
                Price = 9.00,
                IsAvailable = true,
                CategoryId = 2,
                RestaurantId = 5,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                ModifiedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39")
            },
            new FoodItem
            {
                Id = 54,
                Name = "Capricciosa",
                Description = "Pizza with salami and mushrooms",
                Price = 11.00,
                IsAvailable = true,
                CategoryId = 2,
                RestaurantId = 5,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                ModifiedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39")
            },
            new FoodItem
            {
                Id = 55,
                Name = "Salad with cheese",
                Description = "",
                Price = 4.00,
                IsAvailable = true,
                CategoryId = 6,
                RestaurantId = 5,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                ModifiedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39")
            },
            new FoodItem
            {
                Id = 56,
                Name = "Chicken fillets",
                Description = "",
                Price = 6.00,
                IsAvailable = true,
                CategoryId = 5,
                RestaurantId = 5,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                ModifiedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39")
            },
            new FoodItem
            {
                Id = 57,
                Name = "Classic sandwich ",
                Description = "Salami and cheese with lettuce, tomato and onions",
                Price = 6.00,
                IsAvailable = true,
                CategoryId = 8,
                RestaurantId = 5,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                ModifiedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39")
            },
            new FoodItem
            {
                Id = 58,
                Name = "Chicken sandwich ",
                Description = "Chicken and cheese with lettuce, tomato and onions",
                Price = 7.50,
                IsAvailable = true,
                CategoryId = 8,
                RestaurantId = 5,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                ModifiedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39")
            },
            new FoodItem
            {
                Id = 59,
                Name = "Baklava",
                Description = "Homemade baklava, original recipe",
                Price = 4.00,
                IsAvailable = true,
                CategoryId = 10,
                RestaurantId = 5,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                ModifiedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39")
            },
            new FoodItem
            {
                Id = 60,
                Name = "Nutella pancakes",
                Description = "Nutella filled pancakakes",
                Price = 7.00,
                IsAvailable = true,
                CategoryId = 11,
                RestaurantId = 5,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                ModifiedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39")
            },
            new FoodItem
            {
                Id = 61,
                Name = "Jam pancakes",
                Description = "Strawberry jam filled pancakakes",
                Price = 6.00,
                IsAvailable = true,
                CategoryId = 11,
                RestaurantId = 5,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                ModifiedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39")
            },
            new FoodItem
            {
                Id = 62,
                Name = "Margarita",
                Description = "Regular pizza with Gauda cheese",
                Price = 9.00,
                IsAvailable = true,
                CategoryId = 2,
                RestaurantId = 6,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                ModifiedByUserId = Guid.Parse("e7286ada-7ad6-4bb4-8b0a-436141928671")
            },
            new FoodItem
            {
                Id = 63,
                Name = "Capricciosa",
                Description = "Pizza with salami and mushrooms",
                Price = 11.00,
                IsAvailable = true,
                CategoryId = 2,
                RestaurantId = 6,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                ModifiedByUserId = Guid.Parse("e7286ada-7ad6-4bb4-8b0a-436141928671")
            },
            new FoodItem
            {
                Id = 64,
                Name = "Carbonara",
                Description = "",
                Price = 11.00,
                IsAvailable = true,
                CategoryId = 3,
                RestaurantId = 6,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                ModifiedByUserId = Guid.Parse("e7286ada-7ad6-4bb4-8b0a-436141928671")
            },
            new FoodItem
            {
                Id = 65,
                Name = "Bolognese",
                Description = "",
                Price = 12.00,
                IsAvailable = true,
                CategoryId = 3,
                RestaurantId = 6,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                ModifiedByUserId = Guid.Parse("e7286ada-7ad6-4bb4-8b0a-436141928671")
            },
            new FoodItem
            {
                Id = 66,
                Name = "Pesto",
                Description = "",
                Price = 10.00,
                IsAvailable = true,
                CategoryId = 3,
                RestaurantId = 6,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                ModifiedByUserId = Guid.Parse("e7286ada-7ad6-4bb4-8b0a-436141928671")
            },
            new FoodItem
            {
                Id = 67,
                Name = "Lasagne bolognese",
                Description = "",
                Price = 14.00,
                IsAvailable = true,
                CategoryId = 3,
                RestaurantId = 6,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                ModifiedByUserId = Guid.Parse("e7286ada-7ad6-4bb4-8b0a-436141928671")
            },
            new FoodItem
            {
                Id = 68,
                Name = "Baklava",
                Description = "",
                Price = 4.00,
                IsAvailable = true,
                CategoryId = 10,
                RestaurantId = 6,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                ModifiedByUserId = Guid.Parse("e7286ada-7ad6-4bb4-8b0a-436141928671")
            },
            new FoodItem
            {
                Id = 69,
                Name = "Jam pancakes",
                Description = "",
                Price = 6.00,
                IsAvailable = true,
                CategoryId = 11,
                RestaurantId = 6,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedByUserId = Guid.Parse("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                ModifiedByUserId = Guid.Parse("e7286ada-7ad6-4bb4-8b0a-436141928671")
            },

        };
        }
    }
}
