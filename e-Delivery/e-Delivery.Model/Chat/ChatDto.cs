using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Model.Chat
{
    public class ChatDto
    {
        public Guid Id { get; set; }
        public Guid UserFromId { get; set; }
        public Guid UserToId { get; set; }
        public string? Content { get; set; }
        public bool IsDeleted { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
