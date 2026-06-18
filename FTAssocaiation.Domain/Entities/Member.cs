using FTAssociation.Domain.Enums;

public class Member : AuditableEntity
{
    public string MembershipNumber { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public MemberStatus Status { get; set; }
}