using DTP.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Controllers
{
    [ApiController]
    public class TypeViolationController : ControllerBase
    {
        private readonly ITypeViolationService _typeViolationService;

        public TypeViolationController(ITypeViolationService typeViolationService)
        {
            _typeViolationService = typeViolationService;
        }

        [HttpGet]
        [Route("/GetTypeViolation/{id:int}")]
        public async Task<IActionResult> GetTypeViolation([FromQuery] int Id)
        {
            return Ok(await _typeViolationService.GetProtocolById(Id));
        }

        [HttpGet]
        [Route("/GetByName/{id:int}")]
        public async Task<IActionResult> GetByName([FromQuery] string name)
        {
            return Ok(await _typeViolationService.GetByName(name));
        }

        [HttpGet]
        [Route("/GetTypesViolation/{id:int}")]
        public async Task<IActionResult> GetTypesViolation()
        {
            return Ok(await _typeViolationService.GetAll());
        }
    }
}
