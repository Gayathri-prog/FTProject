using Microsoft.AspNetCore.Identity;

namespace FTAssociation.Infrastructure.Identity;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; } = string.Empty;

    public string FlatNumber { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;
}