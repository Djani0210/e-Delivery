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
    public class Review 
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
        public double Grade { get; set; }
        public string? Description { get; set; }


        [ForeignKey(nameof(RestaurantId))]
        public Restaurant Restaurant { get; set; }
        public int RestaurantId { get; set; }
    }
}
