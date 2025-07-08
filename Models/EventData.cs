// Models/EventData.cs
using System;
using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
    public class EventData
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Today;

        [Required]
        public string Location { get; set; }

        [Required]
        public string Description { get; set; }

        public string Color { get; set; } = "#007bff";

        public bool IsAttending { get; set; } = true;
    }
}
