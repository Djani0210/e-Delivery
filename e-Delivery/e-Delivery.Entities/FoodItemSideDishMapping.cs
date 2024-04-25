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
        public FoodItem FoodItem { get; set; }

        public int SideDishId { get; set; }
        public SideDish SideDish { get; set; }

       
    }
}
