using Microsoft.AspNetCore.Mvc;

namespace TelerikCoreWebApp.Controllers
{
    public class HomeController : DemoBaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
