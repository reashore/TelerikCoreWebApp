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
            new Vendor{VendorId = 1, Name = "Vendor1", OcgNumber = "1", PrimaryAddress = "Address1", ManagingQsArea = "ManagingQsArea1"},
            new Vendor{VendorId = 2, Name = "Vendor2", OcgNumber = "2", PrimaryAddress = "Address2", ManagingQsArea = "ManagingQsArea2"},
            new Vendor{VendorId = 3, Name = "Vendor3", OcgNumber = "3", PrimaryAddress = "Address3", ManagingQsArea = "ManagingQsArea3"},
            new Vendor{VendorId = 4, Name = "Vendor4", OcgNumber = "4", PrimaryAddress = "Address4", ManagingQsArea = "ManagingQsArea4"},
            new Vendor{VendorId = 5, Name = "Vendor5", OcgNumber = "5", PrimaryAddress = "Address5", ManagingQsArea = "ManagingQsArea5"},
        };

        public List<Vendor> Vendors => VendorList;

        public void AddVendor(Vendor vendor)
        {
            VendorList.Add(vendor);
        }
    }
}
