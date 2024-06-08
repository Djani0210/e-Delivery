using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Model.User
{
    public class DeliveryPersonGetVM
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public int? CityId { get; set; }
        public int? RestaurantId { get; set; }
        public bool? IsAvailable { get; set; }
        public TimeSpan? WorkFrom { get; set; }
        public TimeSpan? WorkUntil { get; set; }
    }
}
