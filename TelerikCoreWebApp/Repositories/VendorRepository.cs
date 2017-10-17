using System.Collections.Generic;
using TelerikCoreWebApp.Models;

namespace TelerikCoreWebApp.Repositories
{
    public interface IVendorRepository
    {
        IEnumerable<Vendor> Vendors { get; }
        void AddVendor(Vendor vendor);
    }

    public class VendorRepository : IVendorRepository
    {
        private readonly List<Vendor> _vendorList = new List<Vendor>
        {
            new Vendor{VendorId = 1, Name = "Vendor1"},
            new Vendor{VendorId = 1, Name = "Vendor2"},
            new Vendor{VendorId = 1, Name = "Vendor3"},
            new Vendor{VendorId = 1, Name = "Vendor4"},
            new Vendor{VendorId = 1, Name = "Vendor5"}
        };

        public IEnumerable<Vendor> Vendors => _vendorList;

        public void AddVendor(Vendor vendor)
        {
            _vendorList.Add(vendor);
        }
    }
}
