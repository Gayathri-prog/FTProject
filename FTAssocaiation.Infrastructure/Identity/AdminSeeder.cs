using FTAssociation.Domain.Common;
using Microsoft.AspNetCore.Identity;

namespace FTAssociation.Infrastructure.Identity;

public static class AdminSeeder
{
    public static async Task SeedAsync(
        IServiceProvider serviceProvider)
    {
        var userManager =
            serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

        const string email = "admin@fortune.com";

        var user = await userManager.FindByEmailAsync(email);

        if (user != null)
            return;

        user = new ApplicationUser
        {
            UserName = email,
            Email = email,
            FullName = "System Administrator",
            FlatNumber = "ADMIN"
        };

        var result =
            await userManager.CreateAsync(
                user,
                "Admin@123"
            );

        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(
                user,
                Roles.SuperAdmin);
        }
    }
}