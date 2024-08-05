using Microsoft.EntityFrameworkCore;
using StudentPerformanceTracker.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace StudentPerformanceTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Session> Sessions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    Username = "testuser",
                    Password = "password",
                    Email = "test@example.com",
                    ProfileInfo = "Test user profile info"
                }
            );

            modelBuilder.Entity<Session>().HasData(
                new Session
                {
                    SessionId = 1,
                    UserId = 1,
                    Subject = "Math",
                    StartTime = DateTime.Now.AddHours(-2),
                    EndTime = DateTime.Now.AddHours(-1),
                    Type = "Study",
                    Recurrence = "One-off"
                },
                new Session
                {
                    SessionId = 2,
                    UserId = 1,
                    Subject = "Science",
                    StartTime = DateTime.Now.AddHours(-4),
                    EndTime = DateTime.Now.AddHours(-3),
                    Type = "Break",
                    Recurrence = "One-off"
                }
            );
        }
    }
}
