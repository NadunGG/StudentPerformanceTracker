using StudentPerformanceTracker.Models;
using StudentPerformanceTracker.ViewModels;

namespace StudentPerformanceTracker.Services.Interfaces
{
    public interface IUserService
    {
        void RegisterUser(UserViewModel model);
        User AuthenticateUser(string username, string password);
        User GetUserById(int userId);
        List<User> GetAllUsers();
        User? GetLoggedInUser();
    }
}
