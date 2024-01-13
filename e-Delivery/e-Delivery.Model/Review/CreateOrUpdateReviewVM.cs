using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Model.Review
{
    public class CreateOrUpdateReviewVM
    {
        public double Grade { get; set; }
        public string? Description { get; set; }
        public int RestaurantId { get; set; }
    }
}
