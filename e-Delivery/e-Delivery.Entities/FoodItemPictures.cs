using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace e_Delivery.Entities
{
    public class FoodItemPictures
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public int FileSize { get; set; }


        [ForeignKey(nameof(FoodItem))]
        public int FoodItemId { get; set; }
        [JsonIgnore]
        public FoodItem FoodItem { get; set; }
    }
}
