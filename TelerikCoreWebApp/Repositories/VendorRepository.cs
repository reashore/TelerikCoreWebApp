using System.Collections.Generic;
using TelerikCoreWebApp.Models;

namespace TelerikCoreWebApp.Repositories
{
    public interface IVendorRepository
    {
        List<Vendor> Vendors { get; }
        Vendor this[int id] { get; }
        void AddVendor(Vendor vendor);
        void UpdateVendor(Vendor vendor);
        void DeleteVendor(int id);
    }

    public class VendorRepository : IVendorRepository
    {
        private readonly Dictionary<int, Vendor> _vendorDictionary = new Dictionary<int, Vendor>();

        public VendorRepository()
        {
            List<Vendor> vendorList = new List<Vendor>
            {
                new Vendor {Name = "Vendor0", OcgNumber = "0", PrimaryAddress = "Address0", ManagingQsArea = "ManagingQsArea0"},
                new Vendor {Name = "Vendor1", OcgNumber = "1", PrimaryAddress = "Address1", ManagingQsArea = "ManagingQsArea1"},
                new Vendor {Name = "Vendor2", OcgNumber = "2", PrimaryAddress = "Address2", ManagingQsArea = "ManagingQsArea2"},
                new Vendor {Name = "Vendor3", OcgNumber = "3", PrimaryAddress = "Address3", ManagingQsArea = "ManagingQsArea3"},
                new Vendor {Name = "Vendor4", OcgNumber = "4", PrimaryAddress = "Address4", ManagingQsArea = "ManagingQsArea4"},
                new Vendor {Name = "Vendor5", OcgNumber = "5", PrimaryAddress = "Address5", ManagingQsArea = "ManagingQsArea5"}
            };

            vendorList.ForEach(AddVendor);
        }

        public List<Vendor> Vendors
        {
            get
            {
                List<Vendor> vendors = new List<Vendor>();

                foreach (var keyValuePair in _vendorDictionary)
                {
                    Vendor value = keyValuePair.Value;
                    value.VendorId = keyValuePair.Key;

                    vendors.Add(value);
                }

                return vendors;
            }
        }


        public Vendor this[int id] => _vendorDictionary[id];

        public void AddVendor(Vendor vendor)
        {
            if (vendor.VendorId == 0)
            {
                int key = _vendorDictionary.Count;

                while (_vendorDictionary.ContainsKey(key))
                {
                    key++;
                }

                vendor.VendorId = key;
            }

            _vendorDictionary[vendor.VendorId] = vendor;
        }

        public void UpdateVendor(Vendor vendor) => AddVendor(vendor);

        public void DeleteVendor(int id)
        {
            _vendorDictionary.Remove(id);
        }
    }
}
