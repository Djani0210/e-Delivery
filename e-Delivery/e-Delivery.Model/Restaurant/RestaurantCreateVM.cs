using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Model.Restaurant
{
    public class RestaurantCreateVM
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string OpeningTime { get; set; }
        public string ClosingTime { get; set; }
        public string ContactNumber { get; set; }
        public double DeliveryCharge { get; set; }
        public int DeliveryTime { get; set; }
        public int CityId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int? LogoId { get; set; }
    }
}
