using Microsoft.AspNetCore.Mvc;

namespace TelerikCoreWebApp.Controllers
{
    public class Work2Controller : DemoBaseController
    {
        [HttpGet]
        public IActionResult Index0()
        {
            return View("DisplayControllerAndAction", GetControllerAndAction());
        }

        [HttpGet]
        public IActionResult Index1()
        {
            return View("DisplayControllerAndAction", GetControllerAndAction());
        }

        [HttpGet]
        public IActionResult Index2()
        {
            return View("DisplayControllerAndAction", GetControllerAndAction());
        }

        [HttpGet]
        public IActionResult Index3()
        {
            return View("DisplayControllerAndAction", GetControllerAndAction());
        }

        [HttpGet]
        public IActionResult Index4()
        {
            return View("DisplayControllerAndAction", GetControllerAndAction());
        }

        [HttpGet]
        public IActionResult Index5()
        {
            return View("DisplayControllerAndAction", GetControllerAndAction());
        }

        [HttpGet]
        public IActionResult Index6()
        {
            return View("DisplayControllerAndAction", GetControllerAndAction());
        }
    }
}
