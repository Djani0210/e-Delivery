using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace e_Delivery.Entities
{
    public class FoodItem 

    {
        [Key]
        public int Id { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(CreatedByUserId))]
        public User? CreatedByUser { get; set; }
        public Guid? CreatedByUserId { get; set; }


        [JsonIgnore]
        [ForeignKey(nameof(ModifiedByUserId))]
        public User? ModifiedByUser { get; set; }
        public Guid? ModifiedByUserId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }

        public List<FoodItemPictures> FoodItemPictures { get; set; }


        public List<FoodItemSideDishMapping> FoodItemSideDishMappings { get; } = new List<FoodItemSideDishMapping>();
        public List<SideDish>? SideDishes { get; } = new List<SideDish>();

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
        public int CategoryId { get; set; }


        [ForeignKey(nameof(RestaurantId))]
        public Restaurant Restaurant { get; set; }
        public int RestaurantId { get; set; }
    }
}
