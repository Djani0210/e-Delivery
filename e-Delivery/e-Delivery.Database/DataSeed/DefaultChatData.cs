using e_Delivery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Database.DataSeed
{
    public class DefaultChatData
    {
        public static IEnumerable<Chat> Chats
        {
            get => new List<Chat>
            {
                new Chat
                {
                    Id = Guid.NewGuid(),
                    UserFromId = Guid.Parse("B8396F1D-A29A-4856-A4C1-1312DC97A4A1"), 
                    UserToId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                    Content = "Hello I have your order here!",
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new Chat
                {
                    Id = Guid.NewGuid(),
                    UserFromId = Guid.Parse("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"),
                    UserToId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                    Content = "Hello your order is right outside!",
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new Chat
                {
                    Id = Guid.NewGuid(),
                    UserFromId = Guid.Parse("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"),
                    UserToId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                    Content = "Hello, where is your apartment?",
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

            };
        }
    }
}
