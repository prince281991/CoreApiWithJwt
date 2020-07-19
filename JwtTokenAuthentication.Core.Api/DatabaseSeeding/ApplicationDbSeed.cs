using JwtTokenAuthentication.Core.Api.Contasnts;
using JwtTokenAuthentication.Core.Api.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtTokenAuthentication.Core.Api.DatabaseSeeding
{
    public class ApplicationDbSeed
    {
        public static async Task SeedEssentialData(UserManager<ApplicationUser> userManager,RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(ApplicationRoles.Roles.Administrator.ToString()));
            await roleManager.CreateAsync(new IdentityRole(ApplicationRoles.Roles.Administrator.ToString()));
            await roleManager.CreateAsync(new IdentityRole(ApplicationRoles.Roles.Administrator.ToString()));

            var defaultUser=new ApplicationUser{  Email= DefaultUserDetails.DefaultEmail, UserName=DefaultUserDetails.DefaultUserName, EmailConfirmed = true, PhoneNumberConfirmed = true };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                await userManager.CreateAsync(defaultUser, DefaultUserDetails.DefaultPassword);
                await userManager.AddToRoleAsync(defaultUser, DefaultUserDetails.DefaultRole.ToString());
            }
        }
    }
}
