using System.Collections.Generic;
using TelerikCoreWebApp.Models;

namespace TelerikCoreWebApp.Repositories
{
    public interface IPlaceOfServiceRepository
    {
        List<PlaceOfService> PlaceOfServices { get; }
        void AddPlaceOfService(PlaceOfService placeOfService);
    }

    public class PlaceOfServiceRepository : IPlaceOfServiceRepository
    {
        private readonly List<PlaceOfService> _placeOfServiceList = new List<PlaceOfService>
        {
            new PlaceOfService
            {
                PlaceOfServiceId = 1, Name = "PlaceOfService1"
            },
            new PlaceOfService
            {
                PlaceOfServiceId = 2, Name = "PlaceOfService2"
            },
            new PlaceOfService
            {
                PlaceOfServiceId = 3, Name = "PlaceOfService3"
            },
            new PlaceOfService
            {
                PlaceOfServiceId = 4, Name = "PlaceOfService4"
            },
            new PlaceOfService
            {
                PlaceOfServiceId = 5, Name = "PlaceOfService5"
            }
        };

        public List<PlaceOfService> PlaceOfServices => _placeOfServiceList;

        public void AddPlaceOfService(PlaceOfService placeOfService)
        {
            _placeOfServiceList.Add(placeOfService);
        }
    }
}
