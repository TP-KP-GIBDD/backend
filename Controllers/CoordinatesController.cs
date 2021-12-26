using DTP.Entities;
using DTP.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Controllers
{
    [ApiController]
    public class CoordinatesController : ControllerBase
    {
        private readonly ICoordinatesService _coordinatesService;

        public CoordinatesController(ICoordinatesService coordinatesService)
        {
            _coordinatesService = coordinatesService;
        }

        [HttpGet]
        [Route(nameof(GetCoordinates))]
        public async Task<IActionResult> GetCoordinates([FromQuery] int Id)
        {
            return Ok(await _coordinatesService.GetProtocolById(Id));
        }

        [HttpGet]
        [Route(nameof(GetAllCoordinates))]
        public async Task<IActionResult> GetAllCoordinates()
        {
            return Ok(await _coordinatesService.GetAll());
        }

        [HttpPost]
        [Route(nameof(CreateCoordinates))]
        public async Task<IActionResult> CreateCoordinates([FromQuery] Coordinates coordinates)
        {
            return Ok(await _coordinatesService.Create(coordinates));
        }

        [HttpDelete]
        [Route(nameof(DeleteCoordinates))]
        public async Task DeleteCoordinates([FromQuery] int id)
        {
            await _coordinatesService.Delete(id);
        }

        [HttpPut]
        [Route(nameof(UpdateCoordinates))]
        public async Task UpdateCoordinates([FromQuery] Coordinates coordinates)
        {
            Ok(await _coordinatesService.Update(coordinates));
        }
    }
}
