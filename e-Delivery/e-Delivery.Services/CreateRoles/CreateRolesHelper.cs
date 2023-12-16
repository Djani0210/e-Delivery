using e_Delivery.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.CreateRoles
{
    public static class CreateRolesHelper
    {
        public static async Task CreateRoles(RoleManager<Role> RoleManager)
        {
            //initializing custom roles 

            string[] roleNames = { "Admin", "Desktop", "MobileClient", "MobileDeliveryPerson" };
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    //create the roles and seed them to the database: Question 1
                    roleResult = await RoleManager.CreateAsync(new Role() { Name = roleName });
                }
            }

        }
    }
}
