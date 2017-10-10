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
            return View("DisplayUserInfoForm");
        }

        [HttpPost]
        public IActionResult Index0(UserViewModel userViewModel)
        {
            return RedirectToAction("DisplayUserInfo", userViewModel);
        }

        [HttpGet]
        public IActionResult DisplayUserInfo(UserViewModel userViewModel)
        {
            return View(userViewModel);
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private ControllerAndActionViewModel GetControllerAndAction()
        {
            string controller = (string)RouteData.Values["controller"];
            string action = (string)RouteData.Values["action"];

            ControllerAndActionViewModel controllerAndActionViewModel = new ControllerAndActionViewModel
            {
                Controller = controller,
                Action = action
            };

            return controllerAndActionViewModel;
        }
    }
}
