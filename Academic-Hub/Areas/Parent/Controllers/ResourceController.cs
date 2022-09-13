using Academic_Hub.Models;
using Academic_Hub.Areas.Parent.Models;
using Academic_Hub.Models.TestModels;
using Microsoft.AspNetCore.Mvc;

namespace Academic_Hub.Areas.Parent.Controllers
{
    [Area("Parent")]
    public class ResourceController : Controller
    {
        public UserList Data = new UserList();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GenerateReport()
        {
            var model = new ReportViewModel(UserLogger.GetLoggedParent().ParentId);
            return View("Results", model);
        }
    }
}
