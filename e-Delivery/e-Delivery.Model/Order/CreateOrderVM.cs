using e_Delivery.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Model.Order
{
    public class CreateOrderVM
    {

        public PaymentMethod PaymentMethod { get; set; }
        public double TotalCost { get; set; }
        public string? Allergies { get; set; }
        public int RestaurantId { get; set; }
        public int CityId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public List<OrderItemVM> OrderItems { get; set; }
    }
}
