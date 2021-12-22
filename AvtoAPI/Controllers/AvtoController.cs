using AvtoAPI.Entities;
using AvtoAPI.Repositories;
using AvtoAPI.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Controllers
{
    [ApiController]
    public class AvtoController : ControllerBase
    {
        private readonly IAvtoService _avtoService;

        public AvtoController(IAvtoService avtoService)
        {
            _avtoService = avtoService;
        }


        [HttpGet]
        [Route(nameof(GetAvto))]
        /*[Authorize(Role.Carowner)]*/
        public async Task<IActionResult> GetAvto([FromQuery] int id)
        {
            return Ok(await _avtoService.GetAvtoById(id));
        }

        [HttpGet]
        [Route(nameof(GetByNumberAvto))]
        /*[Authorize(Role.Carowner)]*/
        public async Task<IActionResult> GetByNumberAvto([FromQuery] string numberAvto)
        {
            return Ok(await _avtoService.GetByNumberAvto(numberAvto));
        }

        [HttpGet]
        [Route(nameof(GetAvtos))]
        /*[Authorize(Role.Carowner)]*/
        public async Task<IActionResult> GetAvtos()
        {
            return Ok(await _avtoService.GetAll());
        }

        [HttpPost]
        [Route(nameof(CreateAvto))]
        /*[Authorize(Role.Carowner)]*/
        public async Task<IActionResult> CreateAvto([FromQuery] Avto avto)
        {
            return Ok(await _avtoService.Create(avto));
        }

        [HttpDelete]
        [Route(nameof(DeleteAvto))]
        /*[Authorize(Role.Carowner)]*/
        public async Task DeleteAvto([FromQuery] int id)
        {
            await _avtoService.DeleteAvto(id);
        }

        [HttpPut]
        [Route(nameof(UpdateAvto))]
        /*[Authorize(Role.Carowner)]*/
        public async Task UpdateAvto ([FromQuery] Avto avto)
        {
            Ok(await _avtoService.UpdateAvto(avto));
        }
    }
}