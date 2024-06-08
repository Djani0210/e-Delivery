using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Model
{
    public class ApplyMessage
    {
        public string DeliveryPersonEmail { get; set; }
        public string RestaurantOwnerEmail { get; set; }
        public string ConfirmationLink { get; set; }
    }

}
