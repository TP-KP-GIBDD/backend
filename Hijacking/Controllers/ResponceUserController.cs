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
        [Route("/getById/{id}")]
        /*[Authorize(Role.Inspector)]*/
        public async Task<IActionResult> GetResponce([FromQuery] int id)
        {
            return Ok(await _responceUser.GetResponceId(id));
        }

        [HttpGet]
        [Route("/getAll")]
        /*[Authorize(Role.Inspector)]*/
        public async Task<IActionResult> GetResponces()
        {
            return Ok(await _responceUser.GetAll());
        }

        [HttpPost]
        [Route("/create")]
        /*[Authorize(Role.Inspector)]*/
        public async Task<IActionResult> Create([FromQuery] ResponceUser responceUser)
        {
            return Ok(await _responceUser.Create(responceUser));
        }

        //[HttpDelete]
        //[Route("/delete")]
        ///*[Authorize(Role.Admin)]*/
        //public async Task Delete([FromQuery] int id)
        //{
        //    await _responceUser.Delete(id);
        //}

        [HttpPut]
        [Route("/update")]
        /*[Authorize(Role.Inspector)]*/
        public async Task Update([FromQuery] ResponceUser responceUser)
        {
            Ok(await _responceUser.Update(responceUser));
        }
    }
}

