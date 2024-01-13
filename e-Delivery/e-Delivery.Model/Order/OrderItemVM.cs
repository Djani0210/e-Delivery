using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Model.Order
{
    public class OrderItemVM
    {
        public int FoodItemId { get; set; }
        public List<int>? SideDishIds { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }
        
    }
}
