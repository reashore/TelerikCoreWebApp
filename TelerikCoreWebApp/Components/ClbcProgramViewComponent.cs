﻿using Microsoft.AspNetCore.Mvc;

namespace TelerikCoreWebApp.Components
{
    public class ClbcProgramViewComponent : ViewComponent
    {
        //private readonly IVendorRepository _vendorRepository;

        //public ClbcProgramViewComponent(IVendorRepository vendorRepository)
        //{
        //    _vendorRepository = vendorRepository;
        //}

        //public ClbcProgramViewComponent()
        //{
            
        //}

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

            return View("ClbcProgram");
        }
    }
}
