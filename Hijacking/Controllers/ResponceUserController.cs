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
    public class ResponceUserController : ControllerBase
    {
        private readonly IResponceUserService _responceUser;

        public ResponceUserController(IResponceUserService responceUser)
        {
            _responceUser = responceUser;
        }


        [HttpGet]
        [Route(nameof(GetResponce))]
        /*[Authorize(Role.Inspector)]*/
        public async Task<IActionResult> GetResponce([FromQuery] int id)
        {
            return Ok(await _responceUser.GetResponceId(id));
        }

        [HttpGet]
        [Route(nameof(GetResponces))]
        /*[Authorize(Role.Inspector)]*/
        public async Task<IActionResult> GetResponces()
        {
            return Ok(await _responceUser.GetAll());
        }

        [HttpPost]
        [Route(nameof(CreateRU))]
        /*[Authorize(Role.Inspector)]*/
        public async Task<IActionResult> CreateRU([FromQuery] ResponceUser responceUser)
        {
            return Ok(await _responceUser.Create(responceUser));
        }

        [HttpDelete]
        [Route(nameof(DeleteRU))]
        /*[Authorize(Role.Admin)]*/
        public async Task DeleteRU([FromQuery] int id)
        {
            await _responceUser.Delete(id);
        }

        [HttpPut]
        [Route(nameof(UpdateRU))]
        /*[Authorize(Role.Inspector)]*/
        public async Task UpdateRU([FromQuery] ResponceUser responceUser)
        {
            Ok(await _responceUser.Update(responceUser));
        }
    }
}

