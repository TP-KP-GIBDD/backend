using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AvtoAPI.Entities;
using AvtoAPI.Services.Abstracts;

namespace AvtoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorAvtoController : ControllerBase
    {
        private readonly IColorAvtoService _colorAvtoService;

        public ColorAvtoController(IColorAvtoService colorAvtoService)
        {
            _colorAvtoService = colorAvtoService;
        }


        [HttpGet]
        [Route(nameof(GetColorAvto))]
        /*[Authorize(Role.Carowner)]*/
        public async Task<IActionResult> GetColorAvto([FromQuery] int id)
        {
            return Ok(await _colorAvtoService.GetColorAvtoById(id));
        }

        [HttpGet]
        [Route(nameof(GetColorAvtoes))]
        /*[Authorize(Role.Carowner)]*/
        public async Task<IActionResult> GetColorAvtoes()
        {
            return Ok(await _colorAvtoService.GetAll());
        }

        [HttpPost]
        [Route(nameof(CreateColorAvto))]
        /*[Authorize(Role.Carowner)]*/
        public async Task<IActionResult> CreateColorAvto([FromQuery] ColorAvto colorAvto)
        {
            return Ok(await _colorAvtoService.Create(colorAvto));
        }

        [HttpDelete]
        [Route(nameof(DeleteColorAvto))]
        /*[Authorize(Role.Carowner)]*/
        public async Task DeleteColorAvto([FromQuery] int id)
        {
            await _colorAvtoService.DeleteColorAvto(id);
        }

        [HttpPut]
        [Route(nameof(UpdateColorAvto))]
        /*[Authorize(Role.Carowner)]*/
        public async Task UpdateColorAvto([FromQuery] ColorAvto colorAvto)
        {
            Ok(await _colorAvtoService.UpdateColorAvto(colorAvto));
        }
    }
}
