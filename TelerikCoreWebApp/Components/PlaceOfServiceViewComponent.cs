using Microsoft.AspNetCore.Mvc;
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
            return View("PlaceOfService", _placeOfServiceRepository.PlaceOfServices);
        }
    }
}
