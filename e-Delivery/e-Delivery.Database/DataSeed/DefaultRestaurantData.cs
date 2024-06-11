using e_Delivery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Database.DataSeed
{
    public class DefaultRestaurantData
    {
        public static IEnumerable<Restaurant> Restaurants
        {
            get => new List<Restaurant>()
            {
                new Restaurant
                {
                    Id = 1,
                    Name = "Aldi - Caffe slastičarna",
                    Address = "Zagrebačka 6",
                    CreatedDate = DateTime.Now,
                    IsOpen = true,
                    OpeningTime = new TimeSpan(8,0,0),
                    ClosingTime = new TimeSpan(20,0,0),
                    ContactNumber = "063-123-123",
                    DeliveryCharge = 2.50,
                    DeliveryTime = 40,
                    LocationId = 1,
                    LogoId = 1,
                    CreatedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                    ModifiedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),

                },
                new Restaurant
                {
                    Id = 2,
                    Name = "Porto Pizza Mostar",
                    Address = "Brkića 1a",
                    CreatedDate = DateTime.Now,
                    IsOpen = true,
                    OpeningTime = new TimeSpan(8,0,0),
                    ClosingTime = new TimeSpan(22,0,0),
                    ContactNumber = "063-123-124",
                    DeliveryCharge = 2.00,
                    DeliveryTime = 30,
                    LocationId = 2,
                    LogoId = 2,
                    CreatedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                    ModifiedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                },
                new Restaurant
                {
                    Id = 3,
                    Name = "Restoran Radobolja",
                    Address = "Kraljice Katarine 11a",
                    CreatedDate = DateTime.Now,
                    IsOpen = true,
                    OpeningTime = new TimeSpan(10,0,0),
                    ClosingTime = new TimeSpan(21,0,0),
                    ContactNumber = "063-123-125",
                    DeliveryCharge = 3.00,
                    DeliveryTime = 45,
                    LocationId = 3,
                    LogoId = 3,
                    CreatedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621"),
                    ModifiedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621"),
                },
                 new Restaurant
                {
                    Id = 4,
                    Name = "Dva fenjera",
                    Address = "Bišće Polje, M17",
                    CreatedDate = DateTime.Now,
                    IsOpen = true,
                    OpeningTime = new TimeSpan(10,0,0),
                    ClosingTime = new TimeSpan(21,0,0),
                    ContactNumber = "063-123-126",
                    DeliveryCharge = 3.00,
                    DeliveryTime = 50,
                    LocationId = 4,
                    LogoId = 4,
                    CreatedByUserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f"),
                    ModifiedByUserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f"),
                    
                },
                  new Restaurant
                {
                    Id = 5,
                    Name = "Niđe veze",
                    Address = "Husnije Repca 3",
                    CreatedDate = DateTime.Now,
                    IsOpen = true,
                    OpeningTime = new TimeSpan(10,0,0),
                    ClosingTime = new TimeSpan(21,0,0),
                    ContactNumber = "063-123-127",
                    DeliveryCharge = 1.50,
                    DeliveryTime = 30,
                    LocationId = 5,
                    LogoId = 5,
                    CreatedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                    ModifiedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),

                },
                   new Restaurant
                {
                    Id = 6,
                    Name = "Megi Le Petit",
                    Address = "Kralja Tomislava 9",
                    CreatedDate = DateTime.Now,
                    IsOpen = true,
                    OpeningTime = new TimeSpan(10,0,0),
                    ClosingTime = new TimeSpan(21,0,0),
                    ContactNumber = "063-123-128",
                    DeliveryCharge = 2.50,
                    DeliveryTime = 35,
                    LocationId = 6,
                    LogoId = 6,
                    CreatedByUserId = Guid.Parse("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                    ModifiedByUserId = Guid.Parse("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                },
            };
        }
    }
}
