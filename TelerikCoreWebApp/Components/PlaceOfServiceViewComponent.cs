using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TelerikCoreWebApp.Models;
using TelerikCoreWebApp.Repositories;

namespace TelerikCoreWebApp.Components
{
    public class PlaceOfServiceViewComponent : ViewComponent
    {
        private readonly IPlaceOfServiceRepository _placeOfServiceRepository;

        public PlaceOfServiceViewComponent(IPlaceOfServiceRepository placeOfServiceRepository)
        {
            _placeOfServiceRepository = placeOfServiceRepository;
        }

        public IViewComponentResult Invoke()
        {
            List<SelectListItem> vendorSelectListItems = new List<SelectListItem>();

            foreach (PlaceOfService placeOfService in _placeOfServiceRepository.PlacesOfServices)
            {
                var selectListItem = new SelectListItem
                {
                    Value = placeOfService.PlaceOfServiceId.ToString(),
                    Text = placeOfService.Name
                };

                vendorSelectListItems.Add(selectListItem);
            }

            return View(vendorSelectListItems);
        }
    }
}
