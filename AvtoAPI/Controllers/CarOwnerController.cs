using AvtoAPI.Entities;
using AvtoAPI.Repositories;
using AvtoAPI.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Controllers
{
    [ApiController]
    public class CarOwnerController : ControllerBase
    {
        private readonly ICarOwnerService _carOwnerService;

        public CarOwnerController(ICarOwnerService carOwnerService)
        {
            _carOwnerService = carOwnerService;
        }


        [HttpGet]
        [Route(nameof(GetCarOwner))]
        /*[Authorize(Role.Carowner)]*/
        public async Task<IActionResult> GetCarOwner([FromQuery] int id)
        {
            return Ok(await _carOwnerService.GetCarOwnerById(id));
        }

        [HttpGet]
        [Route(nameof(GetCarOwners))]
        /*[Authorize(Role.Carowner)]*/
        public async Task<IActionResult> GetCarOwners()
        {
            return Ok(await _carOwnerService.GetAll());
        }

        [HttpPost]
        [Route(nameof(CreateCarOwner))]
        /*[Authorize(Role.Carowner)]*/
        public async Task<IActionResult> CreateCarOwner([FromQuery] CarOwner carOwner)
        {
            return Ok(await _carOwnerService.Create(carOwner));
        }

        [HttpDelete]
        [Route(nameof(DeleteCarOwner))]
        /*[Authorize(Role.Carowner)]*/
        public async Task DeleteCarOwner([FromQuery] int id)
        {
            await _carOwnerService.DeleteCarOwner(id);
        }

        [HttpPut]
        [Route(nameof(UpdateCarOwner))]
        /*[Authorize(Role.Carowner)]*/
        public async Task UpdateCarOwner([FromQuery] CarOwner carOwner)
        {
            Ok(await _carOwnerService.UpdateCarOwner(carOwner));
        }
    }
}