using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Model.FoodItem
{
    public class CreateFoodItemVM
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
        public int CategoryId { get; set; }
        public int RestaurantId { get; set; }
        public List<int> SideDishIds { get; set; }
    }
}
