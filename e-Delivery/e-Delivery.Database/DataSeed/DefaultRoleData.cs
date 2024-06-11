using e_Delivery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Database.DataSeed
{
    public class DefaultRoleData
    {
        public static IEnumerable<Role> Roles
        {
            get => new List<Role>() {
                new Role
                {
                    Id = Guid.Parse("353224f4-7950-428d-a141-08dc2a5ba67c"),
                    Name = "Admin",
                    IsDeleted = false,
                    NormalizedName = "ADMIN",
                },
                new Role
                {
                    Id = Guid.Parse("f57f872c-eaa4-441e-a142-08dc2a5ba67c"),
                    Name = "Desktop",
                    IsDeleted = false,
                    NormalizedName = "DESKTOP"
                },
                new Role
                {
                    Id = Guid.Parse("67c0d30a-d873-4f9b-a143-08dc2a5ba67c"),
                    Name = "MobileCustomer",
                    IsDeleted = false,
                    NormalizedName = "MOBILECUSTOMER"
                },
                new Role
                {
                    Id = Guid.Parse("7d7168d4-ef7e-4503-a144-08dc2a5ba67c"),
                    Name = "MobileDeliveryPerson",
                    IsDeleted = false,
                    NormalizedName= "MOBILEDELIVERYPERSON"
                }
            };
        }


    }
}
