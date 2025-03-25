using Microsoft.AspNetCore.Identity;
using WithYou_project.Models;

namespace WithYou_project.Database
{
    public static class IntitialSetup
    {
        public static async Task SeedRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            string[] roleNames = { "Admin", "User", "Psychologist" };
            foreach (var roleName in roleNames)
            {
                var roleExists = await roleManager.RoleExistsAsync(roleName);
                if (!roleExists)
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));


                }
            }
        }
        public static async Task SeedAdminUserAsync(UserManager<ApplicationUser> userManager)
        {
            var adminEmail = "admin@example.com";
            var adminUsre = await userManager.FindByEmailAsync(adminEmail);
            if (adminUsre == null)
            {
                var user = new ApplicationUser
                {
                    Email = adminEmail,
                    UserName = adminEmail,
                    FirstName = "Admin",
                    LastName = "User",
                    EmailConfirmed = true

                };
                var result = await userManager.CreateAsync(user, "Admin@12345");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Admin");
                }

            }
        }

        internal static async Task SeedAdminUserAsync(UserManager<IdentityUser> userManager)
        {
            throw new NotImplementedException();
        }
    }

   
}
        
     

    

