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
    public class PlaceViolationController : ControllerBase
    {
        private readonly IPlaceViolationService _placeViolationService;

        public PlaceViolationController(IPlaceViolationService placeViolationService)
        {
            _placeViolationService = placeViolationService;
        }

        [HttpGet]
        [Route("/GetPlaceViolation/{id:int}")]
        public async Task<IActionResult> GetPlaceViolation([FromQuery] int Id)
        {
            return Ok(await _placeViolationService.GetPlaceViolationById(Id));
        }

        [HttpGet]
        [Route("/GetPlaceViolations/{id:int}")]
        public async Task<IActionResult> GetPlaceViolations()
        {
            return Ok(await _placeViolationService.GetAll());
        }

        [HttpPost]
        [Route("/CreatePlaceViolation/{id:int}")]
        public async Task<IActionResult> CreatePlaceViolation([FromQuery] PlaceViolation place)
        {
            return Ok(await _placeViolationService.Create(place));
        }

        [HttpDelete]
        [Route("/DeletePlaceViolation/{id:int}")]
        public async Task DeletePlaceViolation([FromQuery] int id)
        {
            await _placeViolationService.Delete(id);
        }

        [HttpPut]
        [Route("/UpdatePlaceViolation/{id:int}")]
        public async Task UpdatePlaceViolation([FromQuery] PlaceViolation place)
        {
            Ok(await _placeViolationService.Update(place));
        }
    }
}
