using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Entities
{
    public class FoodItem : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }

        public List<FoodItemPictures> FoodItemPictures { get; set; }


        public List<FoodItemSideDishMapping> FoodItemSideDishMappings { get; } = new();
        public List<SideDish>? SideDishes { get; } = new();

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
        public int CategoryId { get; set; }


        [ForeignKey(nameof(RestaurantId))]
        public Restaurant Restaurant { get; set; }
        public int RestaurantId { get; set; }
    }
}
