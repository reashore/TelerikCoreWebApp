﻿using Microsoft.AspNetCore.Mvc;
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
        public IActionResult SimpleProgramDemo()
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
                VendorList = _vendorRepository.Vendors,
                SelectedVendorId = "1"
            };

            return View(vendorViewModel);
        }
        
        [HttpPost]
        public IActionResult DropDownListDemo2(string vendorId)
        {
            VendorViewModel vendorViewModel = new VendorViewModel
            {
                VendorList = _vendorRepository.Vendors,
                SelectedVendorId = vendorId
            };

            return View(vendorViewModel);
        }

        [HttpGet]
        public IActionResult DropDownListDemo3()
        {
            VendorViewModel vendorViewModel = new VendorViewModel
            {
                VendorList = _vendorRepository.Vendors,
                SelectedVendorId = "1"
            };

            return View(vendorViewModel);
        }
        
        [HttpPost]
        public IActionResult DropDownListDemo3(string vendorId)
        {
            VendorViewModel vendorViewModel = new VendorViewModel
            {
                VendorList = _vendorRepository.Vendors,
                SelectedVendorId = vendorId
            };

            return View(vendorViewModel);
        }
    }
}
