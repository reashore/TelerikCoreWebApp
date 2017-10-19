using Microsoft.AspNetCore.Mvc;

namespace TelerikCoreWebApp.Controllers
{
    public class ProgramController : DemoBaseController
    {
        [HttpGet]
        public IActionResult DropDownDemo()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ProgramDemo()
        {
            return View();
        }
    }
}
