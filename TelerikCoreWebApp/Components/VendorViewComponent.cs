using Microsoft.AspNetCore.Mvc;
using TelerikCoreWebApp.Repositories;
using TelerikCoreWebApp.ViewModels;

namespace TelerikCoreWebApp.Components
{
    public class VendorViewComponent : ViewComponent
    {
        private readonly IVendorRepository _vendorRepository;

        public VendorViewComponent(IVendorRepository vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }

        public IViewComponentResult Invoke()
        {
            VendorViewModel vendorViewModel = new VendorViewModel
            {
                SelectedVendorId = 1,
                VendorList = _vendorRepository.Vendors
            };

            return View("Vendor", vendorViewModel);
        }
    }
}
