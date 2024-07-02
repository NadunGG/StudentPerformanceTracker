using StudentPerformanceTracker.Models;
using StudentPerformanceTracker.ViewModels;

namespace StudentPerformanceTracker.Services.Interfaces
{
    public interface IReportService
    {
        ReportViewModel GenerateReport();
        string PredictGrade(string subject);
    }
}
