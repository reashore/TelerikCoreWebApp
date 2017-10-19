using Microsoft.AspNetCore.Mvc;
using TelerikCoreWebApp.Repositories;

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
            return View("Vendor", _vendorRepository.Vendors);
        }
    }
}
