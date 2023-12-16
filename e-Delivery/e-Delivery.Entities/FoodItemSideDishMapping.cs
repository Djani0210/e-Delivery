using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Entities
{
    public class FoodItemSideDishMapping
    {
        public int FoodItemId { get; set; }

        public int SideDishId { get; set; }
        
    //    var sideDishesForFoodItem = dbContext.SideDishes
    //.Where(sd => sd.FoodItemId == myFoodItem.ID)
    //.ToList();
    }
}
