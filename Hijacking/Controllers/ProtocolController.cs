using Hijacking.Entities;
using Hijacking.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hijacking.Controllers
{
    [ApiController]
    public class ProtocolController : ControllerBase
    {
        private readonly IProtocolService _protocolService;

        public ProtocolController(IProtocolService protocolService)
        {
            _protocolService = protocolService;
        }


        [HttpGet]
        [Route(nameof(GetProtocol))]
        /*[Authorize(Role.Inspector)]*/
        public async Task<IActionResult> GetProtocol([FromQuery] int id)
        {
            return Ok(await _protocolService.GetProtocolId(id));
        }

        [HttpGet]
        [Route(nameof(GetProtocols))]
        /*[Authorize(Role.Inspector)]*/
        public async Task<IActionResult> GetProtocols()
        {
            return Ok(await _protocolService.GetAll());
        }

        [HttpPost]
        [Route(nameof(Create))]
        /*[Authorize(Role.Inspector)]*/
        public async Task<IActionResult> Create([FromQuery] Protocol protocol)
        {
            return Ok(await _protocolService.Create(protocol));
        }

        [HttpDelete]
        [Route(nameof(Delete))]
        /*[Authorize(Role.Admin)]*/
        public async Task Delete([FromQuery] int id)
        {
            await _protocolService.Delete(id);
        }

        [HttpPut]
        [Route(nameof(Update))]
        /*[Authorize(Role.Inspector)]*/
        public async Task Update([FromQuery] Protocol protocol)
        {
            Ok(await _protocolService.Update(protocol));
        }
    }
}
