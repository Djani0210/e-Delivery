using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Model.Order
{
    public class AssignDeliveryPersonRequest
    {
        public Guid OrderId { get; set; }
        public Guid UserId { get; set; }
    }
}
