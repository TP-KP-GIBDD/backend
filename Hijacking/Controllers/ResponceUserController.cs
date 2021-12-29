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
<<<<<<< HEAD
        [Route("/create")]
=======
        [Route(nameof(CreateRU))]
>>>>>>> e67ce4c3a8e4851e763c26c9bf686fcef3ab566e
        /*[Authorize(Role.Inspector)]*/
        public async Task<IActionResult> CreateRU([FromQuery] ResponceUser responceUser)
        {
            return Ok(await _responceUser.Create(responceUser));
        }

<<<<<<< HEAD
        //[HttpDelete]
        //[Route("/delete")]
        ///*[Authorize(Role.Admin)]*/
        //public async Task Delete([FromQuery] int id)
        //{
        //    await _responceUser.Delete(id);
        //}

        [HttpPut]
        [Route("/update")]
=======
        [HttpDelete]
        [Route(nameof(DeleteRU))]
        /*[Authorize(Role.Admin)]*/
        public async Task DeleteRU([FromQuery] int id)
        {
            await _responceUser.Delete(id);
        }

        [HttpPut]
        [Route(nameof(UpdateRU))]
>>>>>>> e67ce4c3a8e4851e763c26c9bf686fcef3ab566e
        /*[Authorize(Role.Inspector)]*/
        public async Task UpdateRU([FromQuery] ResponceUser responceUser)
        {
            Ok(await _responceUser.Update(responceUser));
        }
    }
}

