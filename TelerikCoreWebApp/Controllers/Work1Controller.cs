using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TelerikCoreWebApp.Models;

namespace TelerikCoreWebApp.Controllers
{
    public class Work1Controller : Controller
    {
        [HttpGet]
        public IActionResult Index0()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index1()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index1(UserViewModel userViewModel)
        {
            return RedirectToAction("DisplayUserInfo", "Work1", userViewModel);
        }

        [HttpGet]
        public IActionResult DisplayUserInfo(UserViewModel userViewModel)
        {
            return View(userViewModel);
        }

        [HttpGet]
        public IActionResult Index2()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index3()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index4()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index5()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index6()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
