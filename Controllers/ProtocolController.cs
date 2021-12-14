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
    public class ProtocolController : ControllerBase
    {
        private readonly IProtocolService _protocolService;

        public ProtocolController(IProtocolService protocolService)
        {
            _protocolService = protocolService;
        }

        [HttpGet]
        [Route(nameof(GetProtocol))]
        public async Task<IActionResult> GetProtocol([FromQuery] int Id)
        {
            return Ok(await _protocolService.GetProtocolById(Id));
        }

        [HttpGet]
        [Route(nameof(GetByAddress))]
        public async Task<IActionResult> GetByAddress([FromQuery] string adress)
        {
            return Ok(await _protocolService.GetByAddress(adress));
        }

        [HttpGet]
        [Route(nameof(GetProtocols))]
        public async Task<IActionResult> GetProtocols()
        {
            return Ok(await _protocolService.GetAll());
        }

        [HttpPost]
        [Route(nameof(CreateProtocol))]
        public async Task<IActionResult> CreateProtocol([FromQuery] Protocol protocol)
        {
            return Ok(await _protocolService.Create(protocol));
        }

        [HttpDelete]
        [Route(nameof(DeleteProtocol))]
        public async Task DeleteProtocol([FromQuery] int id)
        {
            await _protocolService.Delete(id);
        }

        [HttpPut]
        [Route(nameof(UpdateProtocol))]
        public async Task UpdateProtocol([FromQuery] Protocol protocol)
        {
            Ok(await _protocolService.Update(protocol));
        }
    }
}
