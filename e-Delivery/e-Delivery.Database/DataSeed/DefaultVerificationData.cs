using e_Delivery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Database.DataSeed
{
    public class DefaultVerificationData
    {
        public static IEnumerable<Verification> Verifications
        {
            get => new List<Verification>()
            {
                new Verification {
                    Id = Guid.NewGuid(),
                    Code = "8a2f9b",
                    ExpireDate = DateTime.Now.AddMinutes(30),
                    IsConfirmed = false,
                    UserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b")
                },
                new Verification {
                    Id = Guid.NewGuid(),
                    Code = "41d0e5",
                    ExpireDate = DateTime.Now.AddMinutes(30),
                    IsConfirmed = false,
                    UserId = Guid.Parse("B8396F1D-A29A-4856-A4C1-1312DC97A4A1")
                },
                new Verification {
                    Id = Guid.NewGuid(),
                    Code = "c7b3f0",
                    ExpireDate = DateTime.Now.AddMinutes(30),
                    IsConfirmed = false,
                    UserId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045")
                },
            };
        }
    }
}
