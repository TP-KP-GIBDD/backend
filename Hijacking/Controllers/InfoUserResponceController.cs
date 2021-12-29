using Hijacking.Entities;
using Hijacking.Services;
using Hijacking.Services.Abstracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hijacking.Controllers
{
    [ApiController]
    public class InfoUserResponceController : ControllerBase
    {
        private readonly IInfoResponceUserService _responce;

        public InfoUserResponceController(IInfoResponceUserService responce)
        {
            _responce = responce;
        }


        [HttpGet]
        [Route("test/{id}")]
        /*[Authorize(Role.Inspector)]*/
        public async Task<IActionResult> GetInfoResponce([FromQuery] int id)
        {
            return Ok(await _responce.GetResponceId(id));
        }

        [HttpGet]
        [Route(nameof(GetInfoResponces))]
        /*[Authorize(Role.Inspector)]*/
        public async Task<IActionResult> GetInfoResponces()
        {
            return Ok(await _responce.GetAll());
        }

        [HttpPost]
        [Route(nameof(Create))]
        /*[Authorize(Role.Inspector)]*/
        public async Task<IActionResult> Create([FromQuery] InfoResponceUser responceUserInfo)
        {
            return Ok(await _responce.Create(responceUserInfo));
        }

        [HttpDelete]
        [Route(nameof(Delete))]
        /*[Authorize(Role.Admin)]*/
        public async Task Delete([FromQuery] int id)
        {
            await _responce.Delete(id);
        }

        [HttpPut]
        [Route(nameof(Update))]
        /*[Authorize(Role.Inspector)]*/
        public async Task Update([FromQuery] InfoResponceUser responceUserInfo)
        {
            Ok(await _responce.Update(responceUserInfo));
        }
    }
}
