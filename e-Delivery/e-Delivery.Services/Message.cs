using e_Delivery.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services
{
    public class Message
    {
        public virtual ExceptionCode Status { get; set; }
        public virtual string Info { get; set; }
        public virtual object Data { get; set; }
        public virtual bool IsValid { get; set; }

        public Message()
        {
        }
    }
}