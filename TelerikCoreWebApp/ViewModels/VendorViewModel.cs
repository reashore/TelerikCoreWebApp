using System.Collections.Generic;
using TelerikCoreWebApp.Models;

namespace TelerikCoreWebApp.ViewModels
{
    public class VendorViewModel
    {
        public string SelectedVendorId { get; set; }
        public List<Vendor> VendorList { get; set; }
    }
}
