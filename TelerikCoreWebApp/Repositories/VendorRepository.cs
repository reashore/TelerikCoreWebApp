using System.Collections.Generic;
using TelerikCoreWebApp.Models;

namespace TelerikCoreWebApp.Repositories
{
    public interface IVendorRepository
    {
        List<Vendor> Vendors { get; }
        void AddVendor(Vendor vendor);
    }

    public class VendorRepository : IVendorRepository
    {
        private static readonly List<Vendor> VendorList = new List<Vendor>
        {
            new Vendor{VendorId = 1, Name = "Vendor1", OcgNumber = "1", PrimaryAddress = "Address1", ManagingQsArea = "Area1"},
            new Vendor{VendorId = 2, Name = "Vendor2", OcgNumber = "1", PrimaryAddress = "Address1", ManagingQsArea = "Area1"},
            new Vendor{VendorId = 3, Name = "Vendor3", OcgNumber = "2", PrimaryAddress = "Address1", ManagingQsArea = "Area1"},
            new Vendor{VendorId = 4, Name = "Vendor4", OcgNumber = "2", PrimaryAddress = "Address1", ManagingQsArea = "Area1"},
            new Vendor{VendorId = 5, Name = "Vendor5", OcgNumber = "2", PrimaryAddress = "Address1", ManagingQsArea = "Area1"}
        };

        public List<Vendor> Vendors => VendorList;

        public void AddVendor(Vendor vendor)
        {
            VendorList.Add(vendor);
        }
    }
}
