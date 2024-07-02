using StudentPerformanceTracker.Models;

namespace StudentPerformanceTracker.Data
{
    public static class SeedData
    {
        public static void Initialize(DataContext context)
        {
            context.Users.Add(new User
            {
                UserId = 1,
                Username = "testuser",
                Password = "password",
                Email = "test@example.com",
                ProfileInfo = "Test user profile info"
            });

            context.Sessions.Add(new Session
            {
                SessionId = 1,
                UserId = 1,
                Subject = "Math",
                StartTime = DateTime.Now.AddHours(-2),
                EndTime = DateTime.Now.AddHours(-1),
                Type = "Study",
                Recurrence = "One-off"
            });

            context.Sessions.Add(new Session
            {
                SessionId = 2,
                UserId = 1,
                Subject = "Science",
                StartTime = DateTime.Now.AddHours(-4),
                EndTime = DateTime.Now.AddHours(-3),
                Type = "Break",
                Recurrence = "One-off"
            });
        }
    }
}
