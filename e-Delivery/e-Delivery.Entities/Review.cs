using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Entities
{
    public class Review : BaseEntity
    {
        public double Grade { get; set; }
        public string? Description { get; set; }


        [ForeignKey(nameof(RestaurantId))]
        public Restaurant Restaurant { get; set; }
        public int RestaurantId { get; set; }
    }
}
