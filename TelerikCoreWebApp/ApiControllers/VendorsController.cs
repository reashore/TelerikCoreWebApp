using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TelerikCoreWebApp.Models;
using TelerikCoreWebApp.Repositories;

namespace TelerikCoreWebApp.ApiControllers
{
    [Route("api/[controller]")]
    public class VendorsController : Controller
    {
        private readonly IVendorRepository _vendorRepository;

        public VendorsController(IVendorRepository vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }

        [HttpGet]
        public IEnumerable<Vendor> Get() => _vendorRepository.Vendors;

        [HttpGet("{id}")]
        public Vendor Get(int id) => _vendorRepository.Vendors[id];

        [HttpPost]
        public Vendor Post([FromBody] Vendor vendor)
        {
            Vendor newVendor = new Vendor
            {
                VendorId = 0,
                Name = vendor.Name,
                OcgNumber = vendor.OcgNumber,
                ManagingQsArea = vendor.ManagingQsArea,
                PrimaryAddress = vendor.PrimaryAddress
            };

            _vendorRepository.AddVendor(newVendor);

            return newVendor;
        }

        [HttpPut]
        public Vendor Put([FromBody] Vendor vendor)
        {
            _vendorRepository.UpdateVendor(vendor);
            return vendor;
        }

        [HttpDelete]
        public void Delete(int vendorId)
        {
            _vendorRepository.DeleteVendor(vendorId);
        }
    }
}
