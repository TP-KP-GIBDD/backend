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
        [Route("/getById/{id}")]
        /*[Authorize(Role.Inspector)]*/
        public async Task<IActionResult> GetProtocol([FromQuery] int id)
        {
            return Ok(await _protocolService.GetProtocolId(id));
        }

        [HttpGet]
        [Route("/getAll")]
        /*[Authorize(Role.Inspector)]*/
        public async Task<IActionResult> GetProtocols()
        {
            return Ok(await _protocolService.GetAll());
        }

        [HttpPost]
<<<<<<< HEAD
        [Route("/create")]
=======
        [Route(nameof(CreateProtocol))]
>>>>>>> e67ce4c3a8e4851e763c26c9bf686fcef3ab566e
        /*[Authorize(Role.Inspector)]*/
        public async Task<IActionResult> CreateProtocol([FromQuery] Protocol protocol)
        {
            return Ok(await _protocolService.Create(protocol));
        }

        [HttpDelete]
<<<<<<< HEAD
        [Route("/delete")]
=======
        [Route(nameof(DeleteProtocol))]
>>>>>>> e67ce4c3a8e4851e763c26c9bf686fcef3ab566e
        /*[Authorize(Role.Admin)]*/
        public async Task DeleteProtocol([FromQuery] int id)
        {
            await _protocolService.Delete(id);
        }

        [HttpPut]
<<<<<<< HEAD
        [Route("/update")]
=======
        [Route(nameof(UpdateProtocol))]
>>>>>>> e67ce4c3a8e4851e763c26c9bf686fcef3ab566e
        /*[Authorize(Role.Inspector)]*/
        public async Task UpdateProtocol([FromQuery] Protocol protocol)
        {
            Ok(await _protocolService.Update(protocol));
        }
    }
}
