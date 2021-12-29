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
    public class ParticipantsController : ControllerBase
    {
        private readonly IParticipantsService _participantsService;
        
        public ParticipantsController (IParticipantsService participantsService)
        {
            _participantsService = participantsService;
        }

        [HttpGet]
        [Route (nameof(GetParticipant))]
        public async Task<IActionResult> GetParticipant([FromQuery] int Id)
        {
            return Ok(await _participantsService.GetParticipantById(Id));
        }

        [HttpGet]
        [Route(nameof(GetByFullName))]
        public async Task<IActionResult> GetByFullName([FromQuery] string fullName)
        {
            return Ok(await _participantsService.GetByFullName(fullName));
        }

        [HttpGet]
        [Route(nameof(GetAvto))]
        public async Task<IActionResult> GetAvto([FromQuery] int Id)
        {
            return Ok(await _participantsService.GetParticipantByAvtoId(Id));
        }

        [HttpGet]
        [Route(nameof(GetParticipants))]
        public async Task<IActionResult> GetParticipants()
        {
            return Ok(await _participantsService.GetAll());
        }

        [HttpPost]
        [Route(nameof(CreateParticipant))]
        public async Task<IActionResult> CreateParticipant([FromQuery] Participants patricipant)
        {
            return Ok(await _participantsService.Create(patricipant));
        }

        [HttpDelete]
        [Route(nameof(DeleteParticipant))]
        public async Task DeleteParticipant([FromQuery] int id)
        {
            await _participantsService.Delete(id);
        }

        [HttpPut]
        [Route(nameof(UpdateParticipant))]
        public async Task UpdateParticipant([FromQuery] Participants participant)
        {
            Ok(await _participantsService.Update(participant));
        }
    }
}
