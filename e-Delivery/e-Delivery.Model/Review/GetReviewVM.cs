using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Model.Review
{
    public class GetReviewVM
    {
        public int Id { get; set; }
        public double Grade { get; set; }
        public string? Description { get; set; }
        public int RestaurantId { get; set; }
        public string UserName { get; set; } 
        public DateTime CreatedDate { get; set; } 
    }
}
