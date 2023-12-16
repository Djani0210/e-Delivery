using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Entities.Enums
{
    public enum OrderState
    {
        Created = 1,
        InDelivery = 2,
        Delivered = 3,
        Canceled = 4
    }
}
