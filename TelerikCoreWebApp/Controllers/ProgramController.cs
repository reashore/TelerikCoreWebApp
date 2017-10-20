using Microsoft.AspNetCore.Mvc;
using TelerikCoreWebApp.Repositories;
using TelerikCoreWebApp.ViewModels;

namespace TelerikCoreWebApp.Controllers
{
    public class ProgramController : DemoBaseController
    {
        private readonly IVendorRepository _vendorRepository;

        public ProgramController(IVendorRepository vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }

        [HttpGet]
        public IActionResult ProgramDemo()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DropDownListDemo1()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DropDownListDemo2()
        {
            VendorViewModel vendorViewModel = new VendorViewModel
            {
                SelectedVendorId = 1,
                VendorList = _vendorRepository.Vendors
            };

            return View(vendorViewModel);
        }

        [HttpPost]
        public IActionResult DropDownListDemo2(VendorViewModel vendorViewModel)
        {
            return RedirectToAction("DropDownListDemo2");
        }
    }
}
