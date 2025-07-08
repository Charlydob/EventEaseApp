namespace EventEaseApp.Models
{
    public class EventData
    {
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
        public string Location { get; set; } = string.Empty;
        public string Description { get; set; } = "";
        public string Color { get; set; } = "#007bff";
    }
}
