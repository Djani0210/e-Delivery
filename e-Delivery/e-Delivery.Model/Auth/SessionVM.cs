using e_Delivery.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Model.Auth
{
    public class SessionVM
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public int? RestaurantId { get; set; }
        public int? CityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Token { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public long TokenExpireDate { get; set; }
        public Gender? Gender { get; set; }
        public List<string> Roles { get; set; }
        
    }
}
