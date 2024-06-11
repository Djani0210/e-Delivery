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
    public class Location 
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
        public string Longitude { get; set; }
        public string Latitude { get; set; }

        [ForeignKey(nameof(CityId))]
        public City City { get; set; }
        public int CityId { get; set; }
    }
}
