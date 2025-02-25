using System.Diagnostics;
using Lesson2Task1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace Lesson2Task1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            var username = HttpContext.Session.GetString("User");
            var isAdmin = HttpContext.Session.GetInt32("IsAdmin");
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Login", "Login"); 
            }

            ViewBag.Message = isAdmin == 1 ? "You are admin" : "You are not admin";
         
            return View();
        }
        public IActionResult Privacy()
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
