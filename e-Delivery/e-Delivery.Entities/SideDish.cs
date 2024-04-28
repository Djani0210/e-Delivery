using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Entities
{
    public class SideDish
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }

        public List<FoodItemSideDishMapping> FoodItemSideDishMappings { get; set; }
        public List<FoodItem> FoodItems { get; } = new();

        [ForeignKey(nameof(RestaurantId))]
        public Restaurant Restaurant { get; set; }
        public int RestaurantId { get; set; }

        public List<OrderItemSideDish> OrderItemSideDishes { get; set; } = new List<OrderItemSideDish>();
    }
}
