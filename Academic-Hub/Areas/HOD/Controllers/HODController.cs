using Microsoft.AspNetCore.Mvc;

namespace Academic_Hub.Areas.HOD.Controllers
{
    public class HODController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
