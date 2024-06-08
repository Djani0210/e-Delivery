using e_Delivery.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Model.User
{
    public class UserCreateVM
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Gender? Gender { get; set; }
         public bool? IsAvailable { get; set; }
        public string? WorkFrom { get; set; }
        public string? WorkUntil { get; set; }
        public int? RestaurantId { get; set; }
        public int? CityId { get; set; }
        public List<Guid> UserRoles { get; set; }
    }
}
