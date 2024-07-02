using StudentPerformanceTracker.Services.Interfaces;
using StudentPerformanceTracker.Utilities;
using StudentPerformanceTracker.ViewModels;

namespace StudentPerformanceTracker.Services
{
    public class ReportService : IReportService
    {
        private readonly ISessionService _studySessionService;

        public ReportService(ISessionService studySessionService)
        {
            _studySessionService = studySessionService;
        }

        public ReportViewModel GenerateReport()
        {
            var sessions = _studySessionService.GetSessionsForWeek();
            var subjects = sessions.Select(s => s.Subject).Distinct();
            var predictions = new Dictionary<string, string>();

            foreach (var subject in subjects)
            {
                predictions[subject] = PredictGrade(subject);
            }

            return new ReportViewModel
            {
                ReportId = 1,
                UserId = sessions.FirstOrDefault()?.UserId ?? 0,
                WeekStartDate = DateTime.Now.StartOfWeek(DayOfWeek.Monday),
                Sessions = sessions,
                PredictedGrades = predictions
            };
        }

        public string PredictGrade(string subject)
        {
            var sessions = _studySessionService.GetSessionsForWeek().Where(s => s.Subject == subject);
            var totalHours = sessions.Sum(s => s.Duration);

            if (totalHours >= 15) return "A";
            if (totalHours >= 10) return "B";
            if (totalHours >= 5) return "C";
            return "D";
        }
    }
}
