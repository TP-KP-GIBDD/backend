using DTP.Entities;
using DTP.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Services
{
    public class CoordinatesService : ICoordinatesService
    {
        private readonly ICoordinatesService _coordinatesService;

        public async Task<Coordinates> Create(Coordinates coordinates)
        {
            return await _coordinatesService.Create(coordinates);
        }

        public async Task Delete(int Id)
        {
            await _coordinatesService.Delete(Id);
        }

        public async Task<IEnumerable<Coordinates>> GetAll()
        {
            return await _coordinatesService.GetAll();
        }

        public async Task<Coordinates> GetProtocolById(int Id)
        {
            return await _coordinatesService.GetProtocolById(Id);
        }

        public async Task<Coordinates> Update(Coordinates coordinates)
        {
            return await _coordinatesService.Update(coordinates);
        }
    }
}
