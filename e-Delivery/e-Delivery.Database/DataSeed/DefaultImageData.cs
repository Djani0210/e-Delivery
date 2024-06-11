using e_Delivery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Database.DataSeed
{
    public class DefaultImageData
    {
        public static IEnumerable<Image> Images
        {
            get => new List<Image>()
            {
                new Image
                {
                    Id = 1,
                    Path = "/Uploads/Images/f4af967c-1d73-4f02-a576-75e72d542411.jpg",
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b")
                },
                new Image
                {
                    Id = 2,
                    Path = "/Uploads/Images/a38064f5-960d-43ce-9597-ed27fd588419.jpg",
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310")
                },
                new Image
                {
                    Id = 3,
                    Path = "/Uploads/Images/radobolja.jpg",
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621")
                },
                new Image
                {
                    Id = 4,
                    Path = "/Uploads/Images/dva-fenjera.jpg",
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f")
                },
                new Image
                {
                    Id = 5,
                    Path = "/Uploads/Images/48d82799-50bb-46c7-a655-f6860c8877a9.jpg",
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39")
                },
                new Image
                {
                    Id = 6,
                    Path = "/Uploads/Images/megi.jpg",
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("e7286ada-7ad6-4bb4-8b0a-436141928671")
                },
                new Image
                {
                    Id = 7,
                    Path = "/Uploads/Images/9c3affff-791b-4680-8168-13d0b632cf8e.jpg",
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("B8396F1D-A29A-4856-A4C1-1312DC97A4A1"),
                    UserProfilePictureId = Guid.Parse("B8396F1D-A29A-4856-A4C1-1312DC97A4A1"),

                },
                new Image
                {
                    Id = 8,
                    Path = "/Uploads/Images/ed3a87b4-3710-4484-893d-ae4751014dab.jpg",
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"),
                    UserProfilePictureId = Guid.Parse("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"),
                },
                new Image
                {
                    Id = 9,
                    Path = "/Uploads/Images/employee4.jpg",
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"),
                    UserProfilePictureId = Guid.Parse("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"),
                },
                new Image
                {
                    Id = 10,
                    Path = "/Uploads/Images/customer.jpg",
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                    UserProfilePictureId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                },
                new Image
                {
                    Id = 11,
                    Path = "/Uploads/Images/customer1.jpg",
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                    UserProfilePictureId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                },
                new Image
                {
                    Id = 12,
                    Path = "/Uploads/Images/customer2.jpg",
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                    UserProfilePictureId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                },
            };
        }
    }
}
