using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Database.DataSeed
{
    public class DefaultUserRoleData
    {
        public static IEnumerable<IdentityUserRole<Guid>> UserRoles
        {
            get => new List<IdentityUserRole<Guid>>
            {
                  new IdentityUserRole<Guid>
                {
                    UserId = Guid.Parse("4325ff27-c4d1-4ee8-8073-518fafba8678"), // Admin user ID
                    RoleId = Guid.Parse("353224f4-7950-428d-a141-08dc2a5ba67c")  // Admin role ID
                },
                new IdentityUserRole<Guid>
                {
                    UserId = Guid.Parse("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), // Desktop user ID
                    RoleId = Guid.Parse("f57f872c-eaa4-441e-a142-08dc2a5ba67c")  // Desktop role ID
                },
                new IdentityUserRole<Guid>
                {
                    UserId = Guid.Parse("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), // Desktop1 user ID
                    RoleId = Guid.Parse("f57f872c-eaa4-441e-a142-08dc2a5ba67c")  // Desktop role ID
                },
                new IdentityUserRole<Guid>
                {
                    UserId = Guid.Parse("a6262414-844d-4003-9184-1a39fcc8d621"), // Desktop2 user ID
                    RoleId = Guid.Parse("f57f872c-eaa4-441e-a142-08dc2a5ba67c")  // Desktop role ID
                },
                new IdentityUserRole<Guid>
                {
                    UserId = Guid.Parse("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), // Desktop3 user ID
                    RoleId = Guid.Parse("f57f872c-eaa4-441e-a142-08dc2a5ba67c")  // Desktop role ID
                },
                new IdentityUserRole<Guid>
                {
                    UserId = Guid.Parse("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), // Desktop4 user ID
                    RoleId = Guid.Parse("f57f872c-eaa4-441e-a142-08dc2a5ba67c")  // Desktop role ID
                },
                new IdentityUserRole<Guid>
                {
                    UserId = Guid.Parse("e7286ada-7ad6-4bb4-8b0a-436141928671"), // Desktop5 user ID
                    RoleId = Guid.Parse("f57f872c-eaa4-441e-a142-08dc2a5ba67c")  // Desktop role ID
                },
                new IdentityUserRole<Guid>
                {
                    UserId = Guid.Parse("d405edf6-6ebf-4c20-861d-077f70fbcfb7"), // Desktop6 user ID
                    RoleId = Guid.Parse("f57f872c-eaa4-441e-a142-08dc2a5ba67c")  // Desktop role ID
                },
                new IdentityUserRole<Guid>
                {
                    UserId = Guid.Parse("B8396F1D-A29A-4856-A4C1-1312DC97A4A1"), // MobileDeliveryPerson user ID
                    RoleId = Guid.Parse("7d7168d4-ef7e-4503-a144-08dc2a5ba67c")  // MobileDeliveryPerson role ID
                },
                new IdentityUserRole<Guid>
                {
                    UserId = Guid.Parse("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"), // MobileDeliveryPerson1 user ID
                    RoleId = Guid.Parse("7d7168d4-ef7e-4503-a144-08dc2a5ba67c")  // MobileDeliveryPerson role ID
                },
                new IdentityUserRole<Guid>
                {
                    UserId = Guid.Parse("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"), // MobileDeliveryPerson2 user ID
                    RoleId = Guid.Parse("7d7168d4-ef7e-4503-a144-08dc2a5ba67c")  // MobileDeliveryPerson role ID
                },
                new IdentityUserRole<Guid>
                {
                    UserId = Guid.Parse("bb5f8b53-1b9c-404f-86c4-6c6036102045"), // MobileCustomer user ID
                    RoleId = Guid.Parse("67c0d30a-d873-4f9b-a143-08dc2a5ba67c")  // MobileCustomer role ID
                },
                new IdentityUserRole<Guid>
                {
                    UserId = Guid.Parse("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), // MobileCustomer1 user ID
                    RoleId = Guid.Parse("67c0d30a-d873-4f9b-a143-08dc2a5ba67c")  // MobileCustomer role ID
                },
                new IdentityUserRole<Guid>
                {
                    UserId = Guid.Parse("531cbf7f-0aa1-44b2-8186-83867ac6e257"), // MobileCustomer2 user ID
                    RoleId = Guid.Parse("67c0d30a-d873-4f9b-a143-08dc2a5ba67c")  // MobileCustomer role ID
                }
            };
        }
    }
}

