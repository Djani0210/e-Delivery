using e_Delivery.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace e_Delivery.Entities
{
    public class User:IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpireDate { get; set; }
       
        public bool? IsAvailable { get; set; }
        public TimeSpan? WorkFrom { get; set; }
        public TimeSpan? WorkUntil { get; set; }

        [ForeignKey(nameof(RestaurantId))]
        public Restaurant? Restaurant { get; set; }
        public int? RestaurantId { get; set; }

        [ForeignKey(nameof(CityId))]
        public City? City { get; set; }
        public int? CityId { get; set; }

        
    }
}
