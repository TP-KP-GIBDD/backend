
using FineAPI.Entities;
using FineAPI.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineAPI.Controllers
{
    public class FineController : ControllerBase
    {
        private readonly IFineService _fineService;

        public FineController(IFineService fineService)
        {
            _fineService = fineService;
        }


        [HttpGet]
        [Route(nameof(GetFine))]
        [ProducesResponseType(typeof(Fine), StatusCodes.Status200OK)]
        [Authorize]
        public async Task<IActionResult> GetFine([FromQuery] int id)
        {
            return Ok(await _fineService.GetFineById(id));

        }

        [HttpGet]
        [Route(nameof(GetFines))]
        [ProducesResponseType(typeof(IEnumerable<Fine>), StatusCodes.Status200OK)]
        [Authorize]
        public async Task<IActionResult> GetFines()
        {
            return Ok(await _fineService.GetFines());
        }

        [HttpPost]
        [Route(nameof(CreateFine))]
        [ProducesResponseType(typeof(Fine), StatusCodes.Status200OK)]
        /*[Authorize(Role.Inspector)]*/
        public async Task<IActionResult> CreateFine([FromQuery] Fine fine)
        {
            return Ok(await _fineService.CreateFine(fine));
        }

        [HttpDelete]
        [Route(nameof(DeleteFine))]
        public async Task DeleteFine([FromQuery] int id)
        {
            await _fineService.DeleteFine(id);
        }

        [HttpPut]
        [Route(nameof(UpdateFine))]
        [ProducesResponseType(typeof(Fine), StatusCodes.Status200OK)]
        /*[Authorize(Role.Inspector)]*/
        public async Task UpdateFine([FromQuery] Fine fine)
        {
            Ok(await _fineService.UpdateFine(fine));
        }

        [HttpGet]
        [Route(nameof(GetFineByPersonId))]
        public async Task<ActionResult> GetFineByPersonId([FromQuery] int id)
        {
            return Ok(await _fineService.GetFineByPersonId(id));
        }

        [HttpGet]
        [Route(nameof(GetFineByAvtoId))]
        public async Task<ActionResult> GetFineByAvtoId([FromQuery] int id)
        {
            return Ok(await _fineService.GetFineByAvtoId(id));
        }
    }
}