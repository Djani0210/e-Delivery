using e_Delivery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Database.DataSeed
{
    public static class DefaultOrderItemData
    {
        public static IEnumerable<OrderItem> OrderItems
        {
            get => new List<OrderItem>
            {
                new OrderItem
                {
                    Id = 1,
                    FoodItemId = 1,
                    Quantity = 2,
                    Cost = 20.0,
                    OrderId = Guid.Parse("faf51d20-4224-4894-940e-1d916274b611"),
                },
                new OrderItem
                {
                    Id = 2,
                    FoodItemId = 3,
                    Quantity = 2,
                    Cost = 20.0,
                    OrderId = Guid.Parse("faf51d20-4224-4894-940e-1d916274b611"),
                },
                new OrderItem
                {
                    Id = 3,
                    FoodItemId = 4,
                    Quantity = 1,
                    Cost = 10.0,
                    OrderId = Guid.Parse("098f1a2e-656c-4b65-9429-be1a4f1022e7"),
                },
                new OrderItem
                {
                    Id = 4,
                    FoodItemId = 4,
                    Quantity = 1,
                    Cost = 10.0,
                    OrderId = Guid.Parse("15073c29-56ff-4762-8a86-a4211339e0f9"),
                },
                new OrderItem
                {
                    Id = 5,
                    FoodItemId = 4,
                    Quantity = 2,
                    Cost = 10.0,
                    OrderId = Guid.Parse("15073c29-56ff-4762-8a86-a4211339e0f9"),
                },
                new OrderItem
                {
                    Id = 6,
                    FoodItemId = 6,
                    Quantity = 1,
                    Cost = 10.0,
                    OrderId = Guid.Parse("0c54c236-4ec5-40e4-b354-2d50e9000778"),
                },
                new OrderItem
                {
                    Id = 7,
                    FoodItemId = 7,
                    Quantity = 1,
                    Cost = 10.0,
                    OrderId = Guid.Parse("8ce9b7ba-ccff-422c-acc9-ed0a704dacaf"),
                },
                new OrderItem
                {
                    Id = 8,
                    FoodItemId = 8,
                    Quantity = 1,
                    Cost = 10.0,
                    OrderId = Guid.Parse("8ce9b7ba-ccff-422c-acc9-ed0a704dacaf"),
                },
                new OrderItem
                {
                    Id = 9,
                    FoodItemId = 9,
                    Quantity = 1,
                    Cost = 10.0,
                    OrderId = Guid.Parse("e87e91f7-0b36-4c08-83bc-774aacb99ab8"),
                },

                new OrderItem
                {
                    Id = 10,
                    FoodItemId = 10,
                    Quantity = 1,
                    Cost = 10.0,
                    OrderId = Guid.Parse("328ba3f4-7f21-40f2-ada2-f4f55eaef398"),
                },

                new OrderItem
                {
                    Id = 11,
                    FoodItemId = 11,
                    Quantity = 2,
                    Cost = 10.0,
                    OrderId = Guid.Parse("ff454850-5665-4246-aa6f-738cb80aa325"),
                },

                //odavde nemoj side dishes 
                //Restaurant 2
                new OrderItem
                {
                    Id = 12,
                    FoodItemId = 15,
                    Quantity = 2,
                    Cost = 30.0,
                    OrderId = Guid.Parse("551bf252-ccac-49a9-ade0-5b82db0025f6"),
                },
                new OrderItem
                {
                    Id = 13,
                    FoodItemId = 16,
                    Quantity = 2,
                    Cost = 30.0,
                    OrderId = Guid.Parse("5fd9e288-163c-4286-bb40-02213f53198f"),
                },
                //Restaurant 3
                new OrderItem
                {
                    Id = 14,
                    FoodItemId = 29,
                    Quantity = 2,
                    Cost = 15.0,
                    OrderId = Guid.Parse("4cc493e7-886e-425b-83d7-0c433bf07a9c"),
                },
                new OrderItem
                {
                    Id = 15,
                    FoodItemId = 31,
                    Quantity = 2,
                    Cost = 15.0,
                    OrderId = Guid.Parse("650327a7-1218-4306-aca5-cb30ef57de36"),
                },
                //Restaurant 4
                new OrderItem
                {
                    Id = 16,
                    FoodItemId = 44,
                    Quantity = 2,
                    Cost = 15.0,
                    OrderId = Guid.Parse("81dcd144-67d4-4117-ab76-b511689c9cc2"),
                },
                new OrderItem
                {
                    Id = 17,
                    FoodItemId = 45,
                    Quantity = 2,
                    Cost = 15.0,
                    OrderId = Guid.Parse("0167003f-76d8-4736-9010-9f4f756c5107"),
                },
                //Restaurant 5
                new OrderItem
                {
                    Id = 18,
                    FoodItemId = 57,
                    Quantity = 1,
                    Cost = 8.0,
                    OrderId = Guid.Parse("1991b3fc-5625-49fe-ab51-9ab5495340a9"),
                },
                new OrderItem
                {
                    Id = 19,
                    FoodItemId = 58,
                    Quantity = 2,
                    Cost = 10.0,
                    OrderId = Guid.Parse("425aaa01-bd25-4cae-a267-433e6fef7818"),
                },
                //Restaurant 6
                new OrderItem
                {
                    Id = 20,
                    FoodItemId = 67,
                    Quantity = 1,
                    Cost = 4.0,
                    OrderId = Guid.Parse("51fe2fb5-761e-40eb-9518-3be0e95a9af6"),
                },
                new OrderItem
                {
                    Id = 21,
                    FoodItemId = 68,
                    Quantity = 2,
                    Cost = 14.0,
                    OrderId = Guid.Parse("365fd8d6-8de9-4693-bd61-84eb1526c9d9"),
                },
            };
        }
    }
}
