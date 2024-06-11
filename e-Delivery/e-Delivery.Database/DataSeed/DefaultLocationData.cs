using e_Delivery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Database.DataSeed
{
    public class DefaultLocationData
    {

        public static IEnumerable<Location> Locations
        {
            get => new List<Location>()
            {
                new Location
                {
                    Id = 1, //Location for Caffe Slasticarna Aldi created by desktop
                    Latitude = "43.34205",
                    Longitude = "17.80042",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b")
                },
                new Location
                {
                    Id = 2, //Location for Picerija Porto created by desktop1
                    Latitude = "43.34042",
                    Longitude = "17.81526",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310")
                },
                new Location
                {
                    Id = 3, //Location for Restoran Radobolja created by desktop2
                    Latitude = "43.33947",
                    Longitude = "17.80315",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621")
                },
                new Location
                {
                    Id = 4, //Location for Restoran 2 fenjera created by desktop3
                    Latitude = "43.31130",
                    Longitude = "17.83038",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f")
                },
                new Location
                {
                    Id = 5, //Location for Nidje veze created by desktop4
                    Latitude = "43.33823",
                    Longitude = "17.81019",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39")
                },
                new Location
                {
                    Id = 6, //Location for Megi Le Petit created by desktop5
                    Latitude = "43.35016",
                    Longitude = "17.80079",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("e7286ada-7ad6-4bb4-8b0a-436141928671")
                },
                //These are order locations for MobileCustomer
                new Location
                {
                    Id = 7, 
                    Latitude = "43.34731",
                    Longitude = "17.81352",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045")
                },
                new Location
                {
                    Id = 8,
                    Latitude = "43.34745",
                    Longitude = "17.81166",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045")
                },
                new Location
                {
                    Id = 9,
                    Latitude = "43.34666",
                    Longitude = "17.80534",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045")
                },
                new Location
                {
                    Id = 10,
                    Latitude = "43.34988",
                    Longitude = "17.80171",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045")
                },
                new Location
                {
                    Id = 11,
                    Latitude = "43.33786",
                    Longitude = "17.81581",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045")
                },
                new Location
                {
                    Id = 12,
                    Latitude = "43.34458",
                    Longitude = "17.81346",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045")
                },

                //These are locations for MobileCustomer1
                new Location
                {
                    Id = 13,
                    Latitude = "43.34731",
                    Longitude = "17.81352",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9")
                },
                new Location
                {
                    Id = 14,
                    Latitude = "43.34745",
                    Longitude = "17.81166",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9")
                },
                new Location
                {
                    Id = 15,
                    Latitude = "43.34666",
                    Longitude = "17.80534",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9")
                },
                new Location
                {
                    Id = 16,
                    Latitude = "43.34988",
                    Longitude = "17.80171",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9")
                },
                new Location
                {
                    Id = 17,
                    Latitude = "43.33786",
                    Longitude = "17.81581",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9")
                },
                new Location
                {
                    Id = 18,
                    Latitude = "43.34458",
                    Longitude = "17.81346",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9")
                },
                //These are locations for MobileCustomer2
                new Location
                {
                    Id = 19,
                    Latitude = "43.34731",
                    Longitude = "17.81352",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257")
                },
                new Location
                {
                    Id = 20,
                    Latitude = "43.34745",
                    Longitude = "17.81166",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257")
                },
                new Location
                {
                    Id = 21,
                    Latitude = "43.34666",
                    Longitude = "17.80534",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257")
                },
                new Location
                {
                    Id = 22,
                    Latitude = "43.34988",
                    Longitude = "17.80171",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257")
                },
                new Location
                {
                    Id = 23,
                    Latitude = "43.33786",
                    Longitude = "17.81581",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257")
                },
                new Location
                {
                    Id = 24,
                    Latitude = "43.34458",
                    Longitude = "17.81346",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257")
                },
            };
        }
    }
}
