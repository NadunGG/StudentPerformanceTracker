using Microsoft.EntityFrameworkCore;
using StudentPerformanceTracker.Data;
using StudentPerformanceTracker.Models;
using StudentPerformanceTracker.Services.Interfaces;
using StudentPerformanceTracker.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace StudentPerformanceTracker.Services
{
    public class SessionService : ISessionService
    {
        private readonly ApplicationDbContext _context;

        public SessionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddSession(SessionViewModel model)
        {
            var session = new Session
            {
                UserId = model.UserId,
                Subject = model.Subject,
                StartTime = model.StartTime,
                EndTime = model.EndTime,
                Type = model.Type,
                Recurrence = model.Recurrence
            };
            _context.Sessions.Add(session);
            _context.SaveChanges();
        }

        public void UpdateSession(SessionViewModel model)
        {
            var session = _context.Sessions.SingleOrDefault(s => s.SessionId == model.SessionId);
            if (session != null)
            {
                session.Subject = model.Subject;
                session.StartTime = model.StartTime;
                session.EndTime = model.EndTime;
                session.Type = model.Type;
                session.Recurrence = model.Recurrence;
                _context.SaveChanges();
            }
        }

        public void DeleteSession(int sessionId)
        {
            var session = _context.Sessions.SingleOrDefault(s => s.SessionId == sessionId);
            if (session != null)
            {
                _context.Sessions.Remove(session);
                _context.SaveChanges();
            }
        }

        public SessionViewModel? GetSessionById(int sessionId)
        {
            var session = _context.Sessions.SingleOrDefault(s => s.SessionId == sessionId);
            if (session != null)
            {
                return new SessionViewModel
                {
                    SessionId = session.SessionId,
                    UserId = session.UserId,
                    Subject = session.Subject,
                    StartTime = session.StartTime,
                    EndTime = session.EndTime,
                    Type = session.Type,
                    Recurrence = session.Recurrence
                };
            }
            return null;
        }

        public List<SessionViewModel> GetSessionsForWeek()
        {
            return _context.Sessions.Select(s => new SessionViewModel
            {
                SessionId = s.SessionId,
                UserId = s.UserId,
                Subject = s.Subject,
                StartTime = s.StartTime,
                EndTime = s.EndTime,
                Type = s.Type,
                Recurrence = s.Recurrence
            }).ToList();
        }
    }
}
