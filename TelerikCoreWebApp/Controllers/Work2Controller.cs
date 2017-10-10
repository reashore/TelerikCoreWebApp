using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TelerikCoreWebApp.Models;

namespace TelerikCoreWebApp.Controllers
{
    public class Work2Controller : Controller
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
            return View();
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
