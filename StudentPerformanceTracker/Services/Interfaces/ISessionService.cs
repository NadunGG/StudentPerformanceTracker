using StudentPerformanceTracker.Models;
using StudentPerformanceTracker.ViewModels;

namespace StudentPerformanceTracker.Services.Interfaces
{
    public interface ISessionService
    {
        void AddSession(SessionViewModel model);
        void UpdateSession(SessionViewModel model);
        void DeleteSession(int sessionId);
        SessionViewModel? GetSessionById(int sessionId);
        List<SessionViewModel> GetSessionsForWeek();
    }
}
