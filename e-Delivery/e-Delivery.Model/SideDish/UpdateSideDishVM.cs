using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Model.SideDish
{
    public class UpdateSideDishVM
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
        public int RestaurantId { get; set; }
    }
}
