using Academic_Hub.Models;
using Academic_Hub.Models.TestModels;
using Microsoft.AspNetCore.Mvc;
using Academic_Hub.Areas.Parent.Models;

namespace Academic_Hub.Areas.Parent.Controllers
{
    [Area("Parent")]
    public class HomeController : Controller
    {
        private UserList Data = new UserList();
        public IActionResult Index()
        {
            var loggedUser = UserManager.GetLoggedUser();
            var parent = UserList.GetParents().Find(x => x.ParentId == loggedUser.Id);
            UserLogger.LogParent(parent);
            return RedirectToAction("Dashboard");
        }
        public IActionResult Dashboard()
        {
            var model = new DashboardViewModel(UserLogger.GetLoggedParent().Id);
            return View(model);
        }
        [HttpGet]
        public IActionResult Profile()
        {
            var model = UserLogger.GetLoggedParent();
            return View(model);
        }
        public IActionResult UpdateSettings(ParentUser model)
        {
            UserLogger.LogParent(model);
            return RedirectToAction("Profile");
        }
        public IActionResult StudentProgress()
        {
            var student = StudentInfo.GetStudent(UserLogger.GetLoggedParent().ParentId);
            var model = StudentInfo.GetStudentsSubjects(student.StudentId);
            return View(model);
        }
        public IActionResult Logout()
        {
            UserLogger.Logout();
            return RedirectToAction("Index", "Home", new { area = ""});
        }
        public IActionResult Notification()
        {
            var model = new NotificationsViewModel();
            return View(model);
        }
    }
}
