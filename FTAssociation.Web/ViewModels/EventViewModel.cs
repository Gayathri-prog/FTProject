namespace FTAssociation.Web.ViewModels
{
    public class EventViewModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime EventDate { get; set; }

        public string Venue { get; set; }
    }
}