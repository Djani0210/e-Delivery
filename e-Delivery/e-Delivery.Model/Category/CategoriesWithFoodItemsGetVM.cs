using e_Delivery.Entities;
using e_Delivery.Model.FoodItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Model.Category
{
    public class CategoriesWithFoodItemsGetVM
    {
        public string CategoryName { get; set; }
        public List<FoodItemGetVM> FoodItems { get; set; }
    }
}
