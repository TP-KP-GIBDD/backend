using DTP.Entities;
using DTP.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Services
{
    public class PlaceViolationService : IPlaceViolationService
    {
        private readonly IPlaceViolationService _placeViolationService;

        public async Task<PlaceViolation> Create(PlaceViolation place)
        {
            return await _placeViolationService.Create(place);
        }

        public async Task Delete(int Id)
        {
            await _placeViolationService.Delete(Id);
        }

        public async Task<IEnumerable<PlaceViolation>> GetAll()
        {
            return await _placeViolationService.GetAll();
        }

        public async Task<PlaceViolation> GetPlaceViolationById(int Id)
        {
            return await _placeViolationService.GetPlaceViolationById(Id);
        }

        public async Task<PlaceViolation> Update(PlaceViolation place)
        {
            return await _placeViolationService.Update(place);
        }
    }
}
