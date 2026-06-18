using FTAssociation.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace FTAssociation.Infrastructure.Data;

public class FTAssociationDbContext
    : IdentityDbContext<ApplicationUser>
{
    public FTAssociationDbContext(
        DbContextOptions<FTAssociationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}