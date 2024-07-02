using Microsoft.AspNetCore.Mvc;
using StudentPerformanceTracker.Services.Interfaces;

namespace StudentPerformanceTracker.Controllers
{
    public class ReportController : Controller
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        public IActionResult WeeklyReport()
        {
            var report = _reportService.GenerateReport();
            return View(report);
        }
    }
}
