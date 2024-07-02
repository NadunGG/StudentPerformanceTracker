namespace StudentPerformanceTracker.ViewModels
{
    public class ReportViewModel
    {
        public int ReportId { get; set; }
        public int UserId { get; set; }
        public DateTime WeekStartDate { get; set; }
        public List<SessionViewModel> Sessions { get; set; }
        public Dictionary<string, string> PredictedGrades { get; set; }
    }
}
