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
        [Route ("/GetParticipant/{id:int}")]
        public async Task<IActionResult> GetParticipant([FromQuery] int Id)
        {
            return Ok(await _participantsService.GetParticipantById(Id));
        }

        [HttpGet]
        [Route("/GetByFullName/{id:int}")]
        public async Task<IActionResult> GetByFullName([FromQuery] string fullName)
        {
            return Ok(await _participantsService.GetByFullName(fullName));
        }

        [HttpGet]
        [Route("/GetAvto/{id:int}")]
        public async Task<IActionResult> GetAvto([FromQuery] int Id)
        {
            return Ok(await _participantsService.GetParticipantByAvtoId(Id));
        }

        [HttpGet]
        [Route("/GetParticipants/{id:int}")]
        public async Task<IActionResult> GetParticipants()
        {
            return Ok(await _participantsService.GetAll());
        }

        [HttpPost]
        [Route("/CreateParticipant/{id:int}")]
        public async Task<IActionResult> CreateParticipant([FromQuery] Participants patricipant)
        {
            return Ok(await _participantsService.Create(patricipant));
        }

        [HttpDelete]
        [Route("/DeleteParticipant/{id:int}")]
        public async Task DeleteParticipant([FromQuery] int id)
        {
            await _participantsService.Delete(id);
        }

        [HttpPut]
        [Route("/UpdateParticipant/{id:int}")]
        public async Task UpdateParticipant([FromQuery] Participants participant)
        {
            Ok(await _participantsService.Update(participant));
        }
    }
}
