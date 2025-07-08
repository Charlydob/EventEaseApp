using EventEaseApp.Models;
using System.Collections.Generic;

namespace EventEaseApp.Services
{
    public class EventService
    {
        private readonly List<EventData> _events = new();

        public void AddEvent(EventData evt)
        {
            _events.Add(evt);
        }

        public List<EventData> GetEvents()
        {
            return _events;
        }
    }
}
public class EventModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public string ImageUrl { get; set; }

    public EventModel(string name, string description, DateTime date, string location, string imageUrl)
    {
        Name = name;
        Description = description;
        Date = date;
        Location = location;
        ImageUrl = imageUrl;
    }
}