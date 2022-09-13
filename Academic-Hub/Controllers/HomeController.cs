using Academic_Hub.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academic_Hub.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (UserManager.UserLogged())
            {
                return RedirectToAction("Index", "Home",
                        new { area = UserManager.GetLoggedUser().Role });
            }
            return RedirectToAction("Login", "Account");
        }
    }
}
