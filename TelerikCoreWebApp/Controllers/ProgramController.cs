using Microsoft.AspNetCore.Mvc;

namespace TelerikCoreWebApp.Controllers
{
    public class ProgramController : DemoBaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
