using e_Delivery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Database.DataSeed
{
    public class DefaultEmailData
    {
        public static IEnumerable<Email> Emails
        {
            get => new List<Email>()
            {
                new Email {
                    Id = 1,
                    Content = "Verification code",
                    Title = "8a2f9b",
                    UserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b")
                },
                new Email {
                    Id = 2,
                    Content = "Verification code",
                    Title = "41d0e5",
                    UserId = Guid.Parse("B8396F1D-A29A-4856-A4C1-1312DC97A4A1")
                },
                new Email {
                    Id = 3,
                    Content = "Verification code",
                    Title = "c7b3f0",
                    UserId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045")
                },
            };
        }
    }
}
