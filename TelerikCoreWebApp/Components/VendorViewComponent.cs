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
            //List<SelectListItem> vendorSelectListItems = new List<SelectListItem>();

            //foreach (Vendor vendor in _vendorRepository.Vendors)
            //{
            //    var selectListItem = new SelectListItem
            //    {
            //        Value = vendor.VendorId.ToString(),
            //        Text = vendor.Name
            //    };

            //    vendorSelectListItems.Add(selectListItem);
            //}

            return View(_vendorRepository.Vendors);
        }
    }
}
