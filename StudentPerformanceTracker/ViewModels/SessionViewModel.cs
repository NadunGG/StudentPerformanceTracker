using System.ComponentModel.DataAnnotations;

namespace StudentPerformanceTracker.ViewModels
{
    public class SessionViewModel
    {
        public int SessionId { get; set; }
        public int UserId { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public string Type { get; set; } // Study or Break

        [Required]
        public string Recurrence { get; set; } // One-off or Recurring
        public double Duration
        {
            get
            {
                return (EndTime - StartTime).TotalHours;
            }
        }
    }
}
