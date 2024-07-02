namespace StudentPerformanceTracker.Models
{
    public class Report
    {
        public int ReportId { get; set; }
        public int UserId { get; set; }
        public DateTime WeekStartDate { get; set; }
        public List<Session> Sessions { get; set; }
        public string PredictedGrade { get; set; }
    }

}
