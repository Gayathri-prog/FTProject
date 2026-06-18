public class Event : AuditableEntity
{
    public string Title { get; set; }

    public string Description { get; set; }

    public DateTime EventDate { get; set; }
}