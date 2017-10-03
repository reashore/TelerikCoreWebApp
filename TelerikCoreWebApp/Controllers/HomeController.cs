using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TelerikCoreWebApp.Models;

namespace TelerikCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        [HttpGet]
        public IActionResult Index1()
        {
            ViewBag.Message = "Index1 Page";

            return View();
        }

        [HttpPost]
        public IActionResult Index1(UserViewModel userViewModel)
        {
            ViewBag.Message = "Index1 Page";

            return RedirectToAction("DisplayUserInfo", "Home", userViewModel);
        }

        [HttpGet]
        public IActionResult DisplayUserInfo(UserViewModel userViewModel)
        {
            ViewBag.Message = "DisplayUserInfo Page";

            return View(userViewModel);
        }

        [HttpGet]
        public IActionResult Index2()
        {
            ViewBag.Message = "Index2 Page";

            return View();
        }

        [HttpGet]
        public IActionResult Index3()
        {
            ViewBag.Message = "Index2 Page";

            return View();
        }

        [HttpGet]
        public IActionResult Index4()
        {
            ViewBag.Message = "Index2 Page";

            return View();
        }

        [HttpGet]
        public IActionResult Index5()
        {
            ViewBag.Message = "Index2 Page";

            return View();
        }

        [HttpGet]
        public IActionResult Index6()
        {
            ViewBag.Message = "Index2 Page";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
