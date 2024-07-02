using StudentPerformanceTracker.Models;

namespace StudentPerformanceTracker.Data
{
    public class DataContext
    {
        public List<User> Users { get; set; }
        public List<Session> Sessions { get; set; }

        public DataContext()
        {
            Users = new List<User>();
            Sessions = new List<Session>();
        }
    }
}
