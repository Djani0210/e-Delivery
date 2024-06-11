using e_Delivery.Entities.Enums;
using e_Delivery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Database.DataSeed
{
    public static class DefaultOrderData
    {
        public static IEnumerable<Order> Orders
        {
            get => new List<Order>
            {
                new Order
                {
                    Id = Guid.Parse("faf51d20-4224-4894-940e-1d916274b611"),
                    CreatedDate = DateTime.Now,
                    IsPaid = true,
                    IsDeleted = false,
                    Address = "123 Main St",
                    PaymentMethod = PaymentMethod.CreditCard,
                    TotalCost = 50.0,
                    Allergies = "None",
                    OrderState = OrderState.Created,
                    CreatedByUserId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                    RestaurantId = 1, 
                    LocationId = 7 
                },
                new Order
                {
                    Id = Guid.Parse("098f1a2e-656c-4b65-9429-be1a4f1022e7"),
                    CreatedDate = DateTime.Now,
                    IsPaid = true,
                    IsDeleted = false,
                    Address = "123 Main St",
                    PaymentMethod = PaymentMethod.Cash,
                    TotalCost = 40.0,
                    Allergies = "Some nuts",
                    OrderState = OrderState.InDelivery,
                    CreatedByUserId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                    DeliveryPersonAssignedId = Guid.Parse("B8396F1D-A29A-4856-A4C1-1312DC97A4A1"),
                    RestaurantId = 1,
                    LocationId = 8
                },
                 new Order
                {
                    Id = Guid.Parse("15073c29-56ff-4762-8a86-a4211339e0f9"),
                    CreatedDate = DateTime.Now,
                    IsPaid = true,
                    IsDeleted = false,
                    Address = "123 Main St",
                    PaymentMethod = PaymentMethod.CreditCard,
                    TotalCost = 30.0,
                    Allergies = "None",
                    OrderState = OrderState.Created,
                    CreatedByUserId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                    RestaurantId = 1,
                    LocationId = 9
                },
                new Order
                {
                    Id = Guid.Parse("0c54c236-4ec5-40e4-b354-2d50e9000778"),
                    CreatedDate = DateTime.Now,
                    IsPaid = true,
                    IsDeleted = false,
                    Address = "123 Main St",
                    PaymentMethod = PaymentMethod.Cash,
                    TotalCost = 35.0,
                    Allergies = "Some nuts",
                    OrderState = OrderState.InDelivery,
                    CreatedByUserId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                    DeliveryPersonAssignedId = Guid.Parse("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"),
                    RestaurantId = 1,
                    LocationId = 10
                },
                 new Order
                {
                    Id= Guid.Parse("8ce9b7ba-ccff-422c-acc9-ed0a704dacaf"),
                    CreatedDate = DateTime.Now,
                    IsPaid = true,
                    IsDeleted = false,
                    Address = "123 Main St",
                    PaymentMethod = PaymentMethod.CreditCard,
                    TotalCost = 26.0,
                    Allergies = "Maybe a little cream is bad",
                    OrderState = OrderState.Created,
                    CreatedByUserId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                    RestaurantId = 1,
                    LocationId = 11
                },
                new Order
                {
                    Id = Guid.Parse("e87e91f7-0b36-4c08-83bc-774aacb99ab8"),
                    CreatedDate = DateTime.Now,
                    IsPaid = true,
                    IsDeleted = false,
                    Address = "123 Main St",
                    PaymentMethod = PaymentMethod.Cash,
                    TotalCost = 27.0,
                    Allergies = "Some berries",
                    OrderState = OrderState.InDelivery,
                    CreatedByUserId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                    DeliveryPersonAssignedId = Guid.Parse("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"),
                    RestaurantId = 1,
                    LocationId = 12
                },
                new Order
                {
                    Id = Guid.Parse("328ba3f4-7f21-40f2-ada2-f4f55eaef398"),
                    CreatedDate = DateTime.Now,
                    IsPaid = true,
                    IsDeleted = false,
                    Address = "6th street",
                    PaymentMethod = PaymentMethod.CreditCard,
                    TotalCost = 50.0,
                    Allergies = "None",
                    OrderState = OrderState.Created,
                    CreatedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                    RestaurantId = 1,
                    LocationId = 13
                },
                new Order
                {
                    Id = Guid.Parse("551bf252-ccac-49a9-ade0-5b82db0025f6"),
                    CreatedDate = DateTime.Now,
                    IsPaid = true,
                    IsDeleted = false,
                    Address = "6th street",
                    PaymentMethod = PaymentMethod.CreditCard,
                    TotalCost = 36.0,
                    Allergies = "None",
                    OrderState = OrderState.Created,
                    CreatedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                    RestaurantId = 2,
                    LocationId = 14
                },
                new Order
                {
                    Id = Guid.Parse("4cc493e7-886e-425b-83d7-0c433bf07a9c"),
                    CreatedDate = DateTime.Now,
                    IsPaid = true,
                    IsDeleted = false,
                    Address = "6th street",
                    PaymentMethod = PaymentMethod.CreditCard,
                    TotalCost = 12.0,
                    Allergies = "None",
                    OrderState = OrderState.Created,
                    CreatedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                    RestaurantId = 3,
                    LocationId = 15
                },
                new Order
                {
                    Id = Guid.Parse("81dcd144-67d4-4117-ab76-b511689c9cc2"),
                    CreatedDate = DateTime.Now,
                    IsPaid = true,
                    IsDeleted = false,
                    Address = "6th street",
                    PaymentMethod = PaymentMethod.CreditCard,
                    TotalCost = 21.0,
                    Allergies = "None",
                    OrderState = OrderState.Created,
                    CreatedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                    RestaurantId = 4,
                    LocationId = 16
                },
                new Order
                {
                    Id = Guid.Parse("1991b3fc-5625-49fe-ab51-9ab5495340a9"),
                    CreatedDate = DateTime.Now,
                    IsPaid = true,
                    IsDeleted = false,
                    Address = "6th street",
                    PaymentMethod = PaymentMethod.CreditCard,
                    TotalCost = 48.0,
                    Allergies = "None",
                    OrderState = OrderState.Created,
                    CreatedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                    RestaurantId = 5,
                    LocationId = 17
                },
                new Order
                {
                    Id = Guid.Parse("51fe2fb5-761e-40eb-9518-3be0e95a9af6"),
                    CreatedDate = DateTime.Now,
                    IsPaid = true,
                    IsDeleted = false,
                    Address = "6th street",
                    PaymentMethod = PaymentMethod.CreditCard,
                    TotalCost = 34.0,
                    Allergies = "None",
                    OrderState = OrderState.Created,
                    CreatedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                    RestaurantId = 6,
                    LocationId = 18
                },
                new Order
                {
                    Id = Guid.Parse("ff454850-5665-4246-aa6f-738cb80aa325"),
                    CreatedDate = DateTime.Now,
                    IsPaid = true,
                    IsDeleted = false,
                    Address = "6th street",
                    PaymentMethod = PaymentMethod.CreditCard,
                    TotalCost = 50.0,
                    Allergies = "None",
                    OrderState = OrderState.Created,
                    CreatedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                    RestaurantId = 1,
                    LocationId = 19
                },
                new Order
                {
                    Id = Guid.Parse("5fd9e288-163c-4286-bb40-02213f53198f"),
                    CreatedDate = DateTime.Now,
                    IsPaid = true,
                    IsDeleted = false,
                    Address = "6th street",
                    PaymentMethod = PaymentMethod.CreditCard,
                    TotalCost = 36.0,
                    Allergies = "None",
                    OrderState = OrderState.Created,
                    CreatedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                    RestaurantId = 2,
                    LocationId = 20
                },
                new Order
                {
                    Id = Guid.Parse("650327a7-1218-4306-aca5-cb30ef57de36"),
                    CreatedDate = DateTime.Now,
                    IsPaid = true,
                    IsDeleted = false,
                    Address = "6th street",
                    PaymentMethod = PaymentMethod.CreditCard,
                    TotalCost = 12.0,
                    Allergies = "None",
                    OrderState = OrderState.Created,
                    CreatedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                    RestaurantId = 3,
                    LocationId = 21
                },
                new Order
                {
                    Id = Guid.Parse("0167003f-76d8-4736-9010-9f4f756c5107"),
                    CreatedDate = DateTime.Now,
                    IsPaid = true,
                    IsDeleted = false,
                    Address = "6th street",
                    PaymentMethod = PaymentMethod.CreditCard,
                    TotalCost = 21.0,
                    Allergies = "None",
                    OrderState = OrderState.Created,
                    CreatedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                    RestaurantId = 4,
                    LocationId = 22
                },
                new Order
                {
                    Id = Guid.Parse("425aaa01-bd25-4cae-a267-433e6fef7818"),
                    CreatedDate = DateTime.Now,
                    IsPaid = true,
                    IsDeleted = false,
                    Address = "6th street",
                    PaymentMethod = PaymentMethod.CreditCard,
                    TotalCost = 48.0,
                    Allergies = "None",
                    OrderState = OrderState.Created,
                    CreatedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                    RestaurantId = 5,
                    LocationId = 23
                },
                new Order
                {
                    Id = Guid.Parse("365fd8d6-8de9-4693-bd61-84eb1526c9d9"),
                    CreatedDate = DateTime.Now,
                    IsPaid = true,
                    IsDeleted = false,
                    Address = "6th street",
                    PaymentMethod = PaymentMethod.CreditCard,
                    TotalCost = 34.0,
                    Allergies = "None",
                    OrderState = OrderState.Created,
                    CreatedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                    RestaurantId = 6,
                    LocationId = 24
                },
            };
        }
    }
}
