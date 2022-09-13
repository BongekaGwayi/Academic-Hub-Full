using Academic_Hub.Models;
using Academic_Hub.Models.TestModels;
using Microsoft.AspNetCore.Mvc;

namespace Academic_Hub.Areas.Parent.Controllers
{
    [Area("Parent")]
    public class MeetingController : Controller
    {

        public IActionResult Index()
        {
            var model = StudentInfo.GetRequests();
            return View(model);
        }
        public IActionResult Search(string keyword)
        {
            var model = StudentInfo.GetRequests().FindAll(x => x.Subject.IndexOf(keyword) > 1);
            return View("Index", model);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(MeetingRequest request)
        {
            StudentInfo.AddMeeting(request);
            return RedirectToAction("Index");
        }
    }
}
