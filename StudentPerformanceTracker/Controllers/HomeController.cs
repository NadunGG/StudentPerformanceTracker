using Microsoft.AspNetCore.Mvc;
using StudentPerformanceTracker.Services.Interfaces;
using StudentPerformanceTracker.ViewModels;
using System.Diagnostics;

namespace StudentPerformanceTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            var user = _userService.GetLoggedInUser();
            return View(user);
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
