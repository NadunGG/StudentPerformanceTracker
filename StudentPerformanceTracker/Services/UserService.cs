using StudentPerformanceTracker.Data;
using StudentPerformanceTracker.Models;
using StudentPerformanceTracker.Services.Interfaces;
using StudentPerformanceTracker.ViewModels;
using System.Security.Claims;

namespace StudentPerformanceTracker.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public void RegisterUser(UserViewModel model)
        {
            var user = new User
            {
                UserId = _context.Users.Count + 1,
                Username = model.Username,
                Password = model.Password,
                Email = model.Email,
                ProfileInfo = model.ProfileInfo
            };
            _context.Users.Add(user);
        }

        public User AuthenticateUser(string username, string password)
        {
            var user = _context.Users.SingleOrDefault(u => u.Username == username && u.Password == password);
            return user;
        }

        public User GetUserById(int userId)
        {
            return _context.Users.SingleOrDefault(u => u.UserId == userId);
        }

        public List<User> GetAllUsers()
        {
            return _context.Users;
        }

        public User? GetLoggedInUser()
        {
            var userIdClaim = _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userIdClaim != null)
            {
                int userId = int.Parse(userIdClaim);
                return GetUserById(userId);
            }
            return null;
        }
    }
}
