using Microso  ft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Lesson2Task1.Models;
using System.Linq;

namespace Lesson2Task1.Controllers
{
    public class LoginController : Controller
    {

        [HttpGet]
        public IActionResult Login() {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string UserName, string Password)
        {
            var user = Lesson2Task1.Models.User.Users.FirstOrDefault(u => u.UserName == UserName && u.Password == Password);

            if (user != null)
            {
                HttpContext.Session.SetString("User", user.UserName);
                HttpContext.Session.SetInt32("IsAdmin", user.IsAdmin ? 1 : 0);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Error = "Invalid username or password";
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
