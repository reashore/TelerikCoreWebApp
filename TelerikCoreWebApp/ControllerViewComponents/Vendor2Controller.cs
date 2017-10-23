//using Microsoft.AspNetCore.Mvc;
//using TelerikCoreWebApp.Controllers;
//using TelerikCoreWebApp.Repositories;
//using TelerikCoreWebApp.ViewModels;

//namespace TelerikCoreWebApp.ControllerViewComponents
//{
//    [ViewComponent(Name = "Vendor2Combo")]
//    public class Vendor2Controller : DemoBaseController
//    {
//        private readonly IVendorRepository _vendorRepository;

//        public Vendor2Controller(IVendorRepository vendorRepository)
//        {
//            _vendorRepository = vendorRepository;
//        }

//        [HttpGet]
//        public IActionResult Index()
//        {
//            VendorViewModel vendorViewModel = new VendorViewModel
//            {
//                VendorList = _vendorRepository.Vendors,
//                SelectedVendorId = "1"
//            };

//            return View(vendorViewModel);
//        }

//        [HttpPost]
//        public IActionResult Index(string vendorId)
//        {
//            VendorViewModel vendorViewModel = new VendorViewModel
//            {
//                VendorList = _vendorRepository.Vendors,
//                SelectedVendorId = vendorId
//            };

//            return View(vendorViewModel);
//        }
//    }
//}
