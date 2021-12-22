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
    public class RudderController : ControllerBase
    {
        private readonly IRudderService _rudderService;

        public RudderController(IRudderService rudderService)
        {
            _rudderService = rudderService;
        }


        [HttpGet]
        [Route(nameof(GetRudder))]
        /*[Authorize(Role.Carowner)]*/
        public async Task<IActionResult> GetRudder([FromQuery] int id)
        {
            return Ok(await _rudderService.GetRudderById(id));
        }

        [HttpGet]
        [Route(nameof(GetRudders))]
        /*[Authorize(Role.Carowner)]*/
        public async Task<IActionResult> GetRudders()
        {
            return Ok(await _rudderService.GetAll());
        }

        [HttpPost]
        [Route(nameof(CreateRudder))]
        /*[Authorize(Role.Carowner)]*/
        public async Task<IActionResult> CreateRudder([FromQuery] Rudder rudder)
        {
            return Ok(await _rudderService.Create(rudder));
        }

        [HttpDelete]
        [Route(nameof(DeleteRudder))]
        /*[Authorize(Role.Carowner)]*/
        public async Task DeleteRudder([FromQuery] int id)
        {
            await _rudderService.DeleteRudder(id);
        }

        [HttpPut]
        [Route(nameof(UpdateRudder))]
        /*[Authorize(Role.Carowner)]*/
        public async Task UpdateRudder([FromQuery] Rudder rudder)
        {
            Ok(await _rudderService.UpdateRudder(rudder));
        }
    }
}