using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistrationAppointService.Models;
using RegistrationAppointService.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RegistrationAppointService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        IRepository<Service, int> _repository;

        public ServiceController(IRepository<Service, int> repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult Get(int id)
        {
            Service region = _repository.Get(id);

            if (region == null)
            {
                return NotFound();
            }

            return Ok(region);
        }

        [HttpGet]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }

        [HttpPost]
        public IActionResult Create([FromBody] Service model)
        {
            if (model == null)
            {
                return BadRequest();
            }

            _repository.Create(model);
            return Ok(model);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Service model)
        {
            if (model == null || model.Id != id)
            {
                return BadRequest();
            }

            Service region = _repository.Get(id);

            if (region == null)
            {
                return NotFound();
            }

            _repository.Update(model);
            return Ok(region);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Service region = _repository.Delete(id);

            if (region == null)
            {
                return BadRequest();
            }

            return Ok(region);
        }

    }
}
