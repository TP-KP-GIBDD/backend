
using FineAPI.Entities;
using FineAPI.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineAPI.Controllers
{
    public class TypeFineController : ControllerBase
    {
        private readonly ITypeFineService _typeFineService;

        public TypeFineController(ITypeFineService typeFineService)
        {
            _typeFineService = typeFineService;
        }


        [HttpGet]
        [Route(nameof(GetTypeFine))]
        /*[Authorize(Role.Carowner)]*/
        public async Task<IActionResult> GetTypeFine([FromQuery] int id)
        {
            return Ok(await _typeFineService.GetTypeFineById(id));
        }

        [HttpGet]
        [Route(nameof(GetTypeFines))]
        /*[Authorize(Role.Carowner)]*/
        public async Task<IActionResult> GetTypeFines()
        {
            return Ok(await _typeFineService.GetTypeFines());
        }

        [HttpPost]
        [Route(nameof(CreateTypeFine))]
        /*[Authorize(Role.Carowner)]*/
        public async Task<IActionResult> CreateTypeFine([FromQuery] TypeFine fine)
        {
            return Ok(await _typeFineService.CreateTypeFine(fine));
        }

        [HttpDelete]
        [Route(nameof(DeleteTypeFine))]
        /*[Authorize(Role.Carowner)]*/
        public async Task DeleteTypeFine([FromQuery] int id)
        {
            await _typeFineService.DeleteTypeFine(id);
        }

        [HttpPut]
        [Route(nameof(UpdateTypeFine))]
        /*[Authorize(Role.Carowner)]*/
        public async Task UpdateTypeFine([FromQuery] TypeFine fine)
        {
            Ok(await _typeFineService.UpdateTypeFine(fine));
        }
    }
}