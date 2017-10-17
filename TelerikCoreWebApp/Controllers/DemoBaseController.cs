using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TelerikCoreWebApp.Models;

namespace TelerikCoreWebApp.Controllers
{
    public class DemoBaseController : Controller
    {
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ControllerAndActionViewModel GetControllerAndAction()
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
