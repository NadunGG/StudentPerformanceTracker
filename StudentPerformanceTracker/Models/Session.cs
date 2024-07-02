namespace StudentPerformanceTracker.Models
{
    public class Session
    {
        public int SessionId { get; set; }
        public int UserId { get; set; }
        public string Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Type { get; set; } // Study or Break
        public string Recurrence { get; set; } // One-off or Recurring
    }

}
