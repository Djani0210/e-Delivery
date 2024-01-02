using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace e_Delivery.Entities
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsOpen { get; set; }
        public TimeSpan OpeningTime { get; set; }
        public TimeSpan ClosingTime { get; set; }
        public string ContactNumber { get; set; }
        public double DeliveryCharge { get; set; }
        public int DeliveryTime { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(LocationId))]
        public Location? Location { get; set; }
        public int? LocationId { get; set; } 

        [ForeignKey(nameof(Logo))]
        public int? LogoId { get; set; }
        public Image? Logo { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(CreatedByUserId))]
        public User CreatedByUser { get; set; }
        public Guid CreatedByUserId { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(ModifiedByUserId))]
        public User ModifiedByUser { get; set; }
        public Guid ModifiedByUserId { get; set; }


    }
}
