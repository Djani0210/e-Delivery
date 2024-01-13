using e_Delivery.Model.FoodItem;
using e_Delivery.Model.SideDish;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Model.Order
{
    public class GetOrderItemVM
    {
        public FoodItemGetVM FoodItem { get; set; }
        public List<GetSideDishVM>? SideDishes { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }
    }
}
