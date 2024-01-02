using e_Delivery.Model.Images;
using e_Delivery.Model.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Model.Restaurant
{
    public class RestaurantGetVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool IsOpen { get; set; }
        public TimeSpan OpeningTime { get; set; }
        public TimeSpan ClosingTime { get; set; }
        public string ContactNumber { get; set; }
        public double DeliveryCharge { get; set; }
        public int DeliveryTime { get; set; }
        public LocationGetVM Location { get; set; }
        public ImageGetVM Image { get; set; }
    }
}
