using DTP.Entities;
using DTP.Models;
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
        [Route("/GetProtocol/")]
        public async Task<IActionResult> GetProtocol([FromQuery] int Id)
        {
            return Ok(await _protocolService.GetProtocolById(Id));
        }

        [HttpGet]
        [Route("/GetProtocolByIdentifier/")]
        public async Task<IActionResult> GetProtocolByIdentifier([FromQuery] int identifier)
        {
            return Ok(await _protocolService.GetProtocolByIdentifier(identifier));
        }

        [HttpGet]
        [Route("/GetProtocolByInspector/")]
        public async Task<IActionResult> GetProtocolByInspector([FromQuery] int inspectorId)
        {
            return Ok(await _protocolService.GetProtocolByInspector(inspectorId));
        }

        [HttpGet]
        [Route("/GetProtocolByAvto/")]
        public async Task<IActionResult> GetProtocolByAvto([FromQuery] int AvtoId)
        {
            return Ok(await _protocolService.GetProtocolByAvto(AvtoId));
        }

        [HttpGet]
        [Route("/GetProtocolByTypeViolation/")]
        public async Task<IActionResult> GetProtocolByTypeViolation(int violationId)
        {
            return Ok(await _protocolService.GetProtocolByTypeViolation(violationId));
        }

        [HttpGet]
        [Route("/GetProtocols/")]
        public async Task<IActionResult> GetProtocols()
        {
            return Ok(await _protocolService.GetAll());
        }

        [HttpPost]
        [Route("/CreateProtocol/")]
        public IActionResult CreateProtocol(ProtocolRequest model)
        {
            _protocolService.Create(model);
            return Ok(new { message = "Added protocol" });
        }

    }
}
