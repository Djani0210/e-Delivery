using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Model.Chat
{
    public class SendMessageDto
    {
        public Guid UserToId { get; set; }
        public string Content { get; set; }
    }
}
