using e_Delivery.Entities.Enums;
using e_Delivery.Model.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Model.Order
{
    public class GetOrderVM
    {
        public Guid Id { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public double TotalCost { get; set; }
        public string Allergies { get; set; }
        public int RestaurantId { get; set; }
        public DateTime CreatedDate { get; set; }
        public LocationGetVM Location { get; set; }
        public List<GetOrderItemVM> OrderItems { get; set; }

    }
}
