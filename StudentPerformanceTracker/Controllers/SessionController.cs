using Microsoft.AspNetCore.Mvc;
using StudentPerformanceTracker.Services;
using StudentPerformanceTracker.Services.Interfaces;
using StudentPerformanceTracker.ViewModels;

namespace StudentPerformanceTracker.Controllers
{
    public class SessionController : Controller
    {
        private readonly ISessionService _sessionService;

        public SessionController(ISessionService sessionService)
        {
            _sessionService = sessionService;
        }

        public IActionResult AddSession()
        {
            return View("AddSession", new SessionViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddSession(SessionViewModel model)
        {
            if (ModelState.IsValid)
            {
                _sessionService.AddSession(model);
                return RedirectToAction("ManageSessions");
            }
            return View(model);
        }

        public IActionResult EditSession(int id)
        {
            var session = _sessionService.GetSessionById(id);
            if (session == null)
            {
                return NotFound();
            }
            return View("EditSession", session);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditSession(int id, SessionViewModel model)
        {
            if (id != model.SessionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _sessionService.UpdateSession(model);
                return RedirectToAction("ManageSessions");
            }
            return View(model);
        }

        public IActionResult DeleteSession(int id)
        {
            _sessionService.DeleteSession(id);
            return RedirectToAction("ManageSessions");
        }

        public IActionResult ManageSessions()
        {
            var sessions = _sessionService.GetSessionsForWeek();
            return View(sessions);
        }
    }


}
