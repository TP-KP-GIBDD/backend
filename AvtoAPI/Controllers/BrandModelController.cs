using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AvtoAPI.Entities;
using AvtoAPI.Services.Abstracts;
using Microsoft.AspNetCore.Authorization;

namespace AvtoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandModelController : ControllerBase
    {
        private readonly IBrandModelService _brandModelService;

        public BrandModelController(IBrandModelService brandModelService)
        {
            _brandModelService = brandModelService;
        }


        [HttpGet]
        [Route(nameof(GetBrandModel))]
        /*[Authorize(Role.Inspector)]*/
        public async Task<IActionResult> GetBrandModel([FromQuery] int id)
        {
            return Ok(await _brandModelService.GetBrandModelById(id));
        }

        [HttpGet]
        [Route(nameof(GetBrandModels))]
        /*[Authorize(Role.Inspector)]*/
        public async Task<IActionResult> GetBrandModels()
        {
            return Ok(await _brandModelService.GetAll());
        }

        [HttpGet]
        [Route(nameof(GetBrandModelByBrandId))]
        /*[Authorize(Role.Inspector)]*/
        public async Task<ActionResult> GetBrandModelByBrandId([FromQuery] int id)
        {
            return Ok(await _brandModelService.GetBrandModelByBrandId(id));
        }

        [HttpPost]
        [Route(nameof(CreateBrandModel))]
        /*[Authorize(Role.Inspector)]*/
        public async Task<IActionResult> CreateBrandModel([FromQuery] BrandModel brandModel)
        {
            return Ok(await _brandModelService.Create(brandModel));
        }

        [HttpDelete]
        [Route(nameof(DeleteBrandModel))]
        /*[Authorize(Role.Inspector)]*/
        public async Task DeleteBrandModel([FromQuery] int id)
        {
            await _brandModelService.DeleteBrandModel(id);
        }

        [HttpPut]
        [Route(nameof(UpdateBrandModel))]
        /*[Authorize(Role.Inspector)]*/
        public async Task UpdateBrandModel([FromQuery] BrandModel brandModel)
        {
            Ok(await _brandModelService.UpdateBrandModel(brandModel));
        }
    }
}
