using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Entities
{
    public class OrderItemSideDish
    {
        public int OrderItemId { get; set; }
        public OrderItem OrderItem { get; set; }

        public int SideDishId { get; set; }
        public SideDish SideDish { get; set; }
    }
}
