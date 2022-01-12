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
        [Route("/GetProtocol/{id:int}")]
        public async Task<IActionResult> GetProtocol([FromQuery] int Id)
        {
            return Ok(await _protocolService.GetProtocolById(Id));
        }

        [HttpGet]
        [Route("/GetProtocolByIdentifier/{id:int}")]
        public async Task<IActionResult> GetProtocolByIdentifier([FromQuery] int identifier)
        {
            return Ok(await _protocolService.GetProtocolByIdentifier(identifier));
        }

        [HttpGet]
        [Route("/GetProtocolByInspector/{id:int}")]
        public async Task<IActionResult> GetProtocolByInspector([FromQuery] string inspector)
        {
            return Ok(await _protocolService.GetProtocolByInspector(inspector));
        }

        [HttpGet]
        [Route("/GetProtocolByTypeViolation/{id:int}")]
        public async Task<IActionResult> GetProtocolByTypeViolation(int violation)
        {
            return Ok(await _protocolService.GetProtocolByTypeViolation(violation));
        }

        [HttpGet]
        [Route("/GetProtocols/{id:int}")]
        public async Task<IActionResult> GetProtocols()
        {
            return Ok(await _protocolService.GetAll());
        }

        [HttpPost]
        [Route("/CreateProtocol/{id:int}")]
        public async Task<IActionResult> CreateProtocol([FromQuery] Protocol protocol)
        {
            return Ok(await _protocolService.Create(protocol));
        }

        [HttpDelete]
        [Route("/DeleteProtocol/{id:int}")]
        public async Task DeleteProtocol([FromQuery] int id)
        {
            await _protocolService.Delete(id);
        }

        [HttpPut]
        [Route("/UpdateProtocol/{id:int}")]
        public async Task UpdateProtocol([FromQuery] Protocol protocol)
        {
            Ok(await _protocolService.Update(protocol));
        }
    }
}
