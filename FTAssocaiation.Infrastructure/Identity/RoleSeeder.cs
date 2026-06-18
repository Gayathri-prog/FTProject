using FTAssociation.Domain.Common;
using Microsoft.AspNetCore.Identity;

namespace FTAssociation.Infrastructure.Identity;

public static class RoleSeeder
{
    public static async Task SeedAsync(
        IServiceProvider serviceProvider)
    {
        var roleManager =
            serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        string[] roles =
        {
            Roles.SuperAdmin,
            Roles.Admin,
            Roles.Resident
        };

        foreach (var role in roles)
        {
            if (!await roleManager.RoleExistsAsync(role))
            {
                await roleManager.CreateAsync(
                    new IdentityRole(role));
            }
        }
    }
}