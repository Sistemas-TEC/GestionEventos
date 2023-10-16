namespace LayoutTemplateWebApp.DbModels
{
    public class Event
    {  
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public int EventStateId { get; set; }
    public string Description { get; set; }
    public string Organizer { get; set; }
    public string MaxCapacity { get; set; }
    public string EntryCost { get; set; }
    public int EventTypeId { get; set; }
}
}
