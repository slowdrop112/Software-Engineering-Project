using Microsoft.AspNetCore.Identity;
using Uniflow.Data; 

namespace Uniflow
{
    public static class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            // 1. Crearea Rolurilor (Admin, Profesor, Student)
            string[] roleNames = { "Admin", "Profesor", "Student" };
            foreach (var roleName in roleNames)
            {
                if (!await roleManager.RoleExistsAsync(roleName))
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            // 2. Crearea primului utilizator Administrator
            var adminEmail = "admin@uniflow.com";
            var adminUser = await userManager.FindByEmailAsync(adminEmail);

            if (adminUser == null)
            {
                var user = new IdentityUser { UserName = adminEmail, Email = adminEmail, EmailConfirmed = true };
                var result = await userManager.CreateAsync(user, "Admin123!"); // !!! Parola temporară

                if (result.Succeeded)
                {
                    // Asignarea rolului de Admin
                    await userManager.AddToRoleAsync(user, "Admin");
                }
            }
        }
    }
}
