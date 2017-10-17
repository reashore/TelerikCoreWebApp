using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TelerikCoreWebApp.Models;

namespace TelerikCoreWebApp.Controllers
{
    public class Work3Controller : DemoBaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            Partial1ViewModel partial1ViewModel = new Partial1ViewModel
            {
                Title = "Partial View1 Title"
            };

            Partial2ViewModel partial2ViewModel = new Partial2ViewModel
            {
                Title = "Partial View2 Title"
            };

            Partial3ViewModel partial3ViewModel = new Partial3ViewModel
            {
                Title = "Partial View3 Title"
            };

            ControllerAndActionViewModel controllerAndActionViewModel = GetControllerAndAction();

            CompositeViewModel compositeViewModel = new CompositeViewModel
            {
                ControllerAndActionViewModel = controllerAndActionViewModel,
                Partial1ViewModel = partial1ViewModel,
                Partial2ViewModel = partial2ViewModel,
                Partial3ViewModel = partial3ViewModel
            };

            return View(compositeViewModel);
        }
    }
}
