using e_Delivery.Entities;
using e_Delivery.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Database.DataSeed
{
    public class DefaultUserData
    {
        public static IEnumerable<User> Users
        {
            get => new List<User>() {
                new User
                {
                    Id = Guid.Parse("4325ff27-c4d1-4ee8-8073-518fafba8678"),
                    CreatedDate = DateTime.Parse("2024-02-07 17:26:40.8999869"),

                    IsAvailable = true,
                    FirstName = "Admin",
                    LastName = "Admin",
                    
                    CityId = 1,
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "edeliveryadmin@gmail.com",
                    NormalizedEmail = "EMPLOYEE@EMPLOYEE.COM",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "061-502-342",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    AccessFailedCount = 0
                },
                new User
                {
                    Id = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                    CreatedDate = DateTime.Parse("2024-02-07 17:26:40.8999869"),

                    IsAvailable = true,
                    FirstName = "desktop",
                    LastName = "User",
                    
                    CityId = 1,
                    UserName = "desktop",
                    NormalizedUserName = "DESKTOP",
                    Email = "belminedelivery@gmail.com",
                    NormalizedEmail = "BELMINEDELIVERY@GMAIL.COM",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "061-111-111",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    RestaurantId = 1,
                    
                },
                 new User
                {
                    Id = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                    CreatedDate = DateTime.Parse("2024-02-07 17:26:40.8999869"),

                    IsAvailable = true,
                    FirstName = "desktop1",
                    LastName = "User1",
                    
                    CityId = 1,
                    UserName = "desktop1",
                    NormalizedUserName = "DESKTOP1",
                    Email = "desktop1edelivery@gmail.com",
                    NormalizedEmail = "DESKTOP1EDELIVERY@GMAIL.COM",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "061-111-112",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                     RestaurantId = 2
                },
                   new User
                {
                    Id = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621"),
                    CreatedDate = DateTime.Parse("2024-02-07 17:26:40.8999869"),

                    IsAvailable = true,
                    FirstName = "desktop2",
                    LastName = "User2",
                    
                    CityId = 1,
                    UserName = "desktop2",
                    NormalizedUserName = "DESKTOP2",
                    Email = "desktop2edelivery@gmail.com",
                    NormalizedEmail = "DESKTOP2EDELIVERY@GMAIL.COM",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "061-111-113",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    RestaurantId = 3

                },
                    new User
                {
                    Id = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f"),
                    CreatedDate = DateTime.Parse("2024-02-07 17:26:40.8999869"),

                    IsAvailable = true,
                    FirstName = "desktop3",
                    LastName = "User3",
                    
                    CityId = 1,
                    UserName = "desktop3",
                    NormalizedUserName = "DESKTOP3",
                    Email = "desktop3edelivery@gmail.com",
                    NormalizedEmail = "DESKTOP3EDELIVERY@GMAIL.COM",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "061-111-114",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    RestaurantId= 4,
                },
                    new User
                {
                    Id = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                    CreatedDate = DateTime.Parse("2024-02-07 17:26:40.8999869"),

                    IsAvailable = true,
                    FirstName = "desktop4",
                    LastName = "User4",
                    
                    CityId = 1,
                    UserName = "desktop4",
                    NormalizedUserName = "DESKTOP4",
                    Email = "desktop4edelivery@gmail.com",
                    NormalizedEmail = "DESKTOP4EDELIVERY@GMAIL.COM",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "123456789",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    RestaurantId = 5,
                },
                    new User
                {
                    Id = Guid.Parse("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                    CreatedDate = DateTime.Parse("2024-02-07 17:26:40.8999869"),

                    IsAvailable = true,
                    FirstName = "desktop5",
                    LastName = "User5",
                    
                    CityId = 1,
                    UserName = "desktop5",
                    NormalizedUserName = "DESKTOP5",
                    Email = "desktop5edelivery@gmail.com",
                    NormalizedEmail = "DESKTOP5EDELIVERY@GMAIL.COM",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "123456789",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    RestaurantId=6
                },
                      new User
                {
                    Id = Guid.Parse("d405edf6-6ebf-4c20-861d-077f70fbcfb7"),
                    CreatedDate = DateTime.Parse("2024-02-07 17:26:40.8999869"),

                    IsAvailable = true,
                    FirstName = "desktop6",
                    LastName = "User6",
                    
                    CityId = 1,
                    UserName = "desktop6",
                    NormalizedUserName = "DESKTOP6",
                    Email = "desktop6edelivery@gmail.com",
                    NormalizedEmail = "DESKTOP6EDELIVERY@GMAIL.COM",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "123456789",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    AccessFailedCount = 0
                },
                new User
                {
                    Id = Guid.Parse("B8396F1D-A29A-4856-A4C1-1312DC97A4A1"),
                    CreatedDate = DateTime.Parse("2024-02-07 17:26:40.8999869"),

                    IsAvailable = true,
                    FirstName = "Employee",
                    LastName = "User",
                    
                    CityId = 1,
                    UserName = "MobileDeliveryPerson",
                    NormalizedUserName = "EMPLOYEE",
                    Email = "flutterhelpme2@gmail.com",
                    WorkFrom = new TimeSpan(10,0,0),
                    WorkUntil = new TimeSpan(18,0,0),
                    RestaurantId = 1,
                    NormalizedEmail = "EMPLOYEE@EMPLOYEE.COM",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "123456789",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    AccessFailedCount = 0
                },
                 new User
                {
                    Id = Guid.Parse("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"),
                    CreatedDate = DateTime.Parse("2024-02-07 17:26:40.8999869"),

                    IsAvailable = true,
                    FirstName = "Employee1",
                    LastName = "User1",
                    
                    CityId = 1,
                    UserName = "MobileDeliveryPerson1",
                    NormalizedUserName = "EMPLOYEE1",
                    Email = "employee1@gmail.com",
                    WorkFrom = new TimeSpan(10,0,0),
                    WorkUntil = new TimeSpan(18,0,0),
                    RestaurantId = 1,
                    NormalizedEmail = "EMPLOYEE1@GMAIL.COM",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "123456789",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    AccessFailedCount = 0
                },
                  new User
                {
                    Id = Guid.Parse("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"),
                    CreatedDate = DateTime.Parse("2024-02-07 17:26:40.8999869"),

                    IsAvailable = true,
                    FirstName = "Employee2",
                    LastName = "User2",
                    
                    CityId = 1,
                    UserName = "MobileDeliveryPerson2",
                    NormalizedUserName = "EMPLOYEE2",
                    Email = "employee2@gmail.com",
                    WorkFrom = new TimeSpan(10,0,0),
                    WorkUntil = new TimeSpan(18,0,0),
                    RestaurantId = 1,
                    NormalizedEmail = "EMPLOYEE2@GMAIL.COM",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "123456789",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    AccessFailedCount = 0
                },
                   new User
                {
                    Id = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                    CreatedDate = DateTime.Parse("2024-02-07 17:26:40.8999869"),

                    IsAvailable = true,
                    FirstName = "Customer",
                    LastName = "User",
                    
                    CityId = 1,
                    UserName = "MobileCustomer",
                    NormalizedUserName = "MOBILECUSTOMER",
                    Email = "kupac11111@gmail.com",
                    NormalizedEmail = "KUPAC11111@GMAIL.COM",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "123456789",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    AccessFailedCount = 0
                },
                    new User
                {
                    Id = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                    CreatedDate = DateTime.Parse("2024-02-07 17:26:40.8999869"),

                   IsAvailable = true,
                    FirstName = "Customer1",
                    LastName = "User1",
                    
                    CityId = 1,
                    UserName = "MobileCustomer1",
                    NormalizedUserName = "MOBILECUSTOMER1",
                    Email = "mobilecustomer1@gmail.com",
                    NormalizedEmail = "MOBILECUSTOMER1@GMAIL.COM",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "123456789",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    AccessFailedCount = 0
                },
                     new User
                {
                    Id = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                    CreatedDate = DateTime.Parse("2024-02-07 17:26:40.8999869"),

                    IsAvailable = true,
                    FirstName = "Custome2",
                    LastName = "User2",
                    
                    CityId = 1,
                    UserName = "MobileCustomer2",
                    NormalizedUserName = "MOBILECUSTOMER2",
                    Email = "mobilecustomer2@gmail.com",
                    NormalizedEmail = "MOBILECUSTOMER2@GMAIL.COM",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "123456789",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    AccessFailedCount = 0
                },
            };
        }
    }
}
