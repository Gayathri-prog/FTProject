namespace FTAssociation.Web.ViewModels
{
    public class MemberViewModel
    {
        public Guid Id { get; set; }

        public string FlatNumber { get; set; }

        public string OwnerName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Block { get; set; }

        public bool IsActive { get; set; }
    }
}