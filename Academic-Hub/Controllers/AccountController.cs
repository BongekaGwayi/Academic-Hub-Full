using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academic_Hub.Models;
using Academic_Hub.Models.TestModels;
using Microsoft.AspNetCore.Mvc;

namespace Academic_Hub.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User model)
        {
            if (ModelState.IsValid)
            {
                bool exists = UserList.GetUsers().Any(x => x.Username == model.Username && x.Password == model.Password);
                if (exists)
                {
                    var validUser = UserList.GetUsers().Find(x => x.Username == model.Username);
                    UserManager.LogUser(validUser);
                    return RedirectToAction("Index", "Home",
                        new { area = UserManager.GetLoggedUser().Role });
                }
            }
            ModelState.AddModelError("", "Invalid credentials");
            return View(model);
        }
    }
}
