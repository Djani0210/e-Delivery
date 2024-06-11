using e_Delivery.Entities.Enums;
using e_Delivery.Model.Restaurant;
using e_Delivery.Model.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Model.User
{
    public class UserGetVM
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
       
        public List<UserRoleGetVM>? Role { get; set; }
        public RestaurantGetVM? Company { get; set; }
        public bool? IsAvailable { get; set; }
        public TimeSpan? WorkFrom { get; set; }
        public TimeSpan? WorkUntil { get; set; }

    }
}
