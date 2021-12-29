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
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }


        [HttpGet]
        [Route(nameof(GetBrand))]
        /*[Authorize(Role.Carowner)]*/
        public async Task<IActionResult> GetBrand([FromQuery] int id)
        {
            return Ok(await _brandService.GetBrandById(id));
        }

        [HttpGet]
        [Route(nameof(GetBrands))]
        /*[Authorize(Role.Carowner)]*/
        public async Task<IActionResult> GetBrands()
        {
            return Ok(await _brandService.GetAll());
        }

        [HttpPost]
        [Route(nameof(CreateBrand))]
        /*[Authorize(Role.Carowner)]*/
        public async Task<IActionResult> CreateBrand([FromQuery] Brand brand)
        {
            return Ok(await _brandService.Create(brand));
        }

        [HttpDelete]
        [Route(nameof(DeleteBrand))]
        /*[Authorize(Role.Carowner)]*/
        public async Task DeleteBrand([FromQuery] int id)
        {
            await _brandService.DeleteBrand(id);
        }

        [HttpPut]
        [Route(nameof(UpdateBrand))]
        /*[Authorize(Role.Carowner)]*/
        public async Task UpdateBrand([FromQuery] Brand brand)
        {
            Ok(await _brandService.UpdateBrand(brand));
        }
    }
}
