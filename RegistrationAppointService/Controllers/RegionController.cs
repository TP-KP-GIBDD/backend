using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistrationAppointService.Models;
using RegistrationAppointService.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationAppointService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        IRepository<Region, int> _repository;

        public RegionController(IRepository<Region, int> repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Region region = _repository.Get(id);

            if (region == null)
            {
                return NotFound();
            }

            return Ok(region);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }

        [HttpPost]
        public IActionResult Create([FromBody] Region model)
        {
            if (model == null)
            {
                return BadRequest();
            }

            _repository.Create(model);
            return Ok(model);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Region model)
        {
            if (model == null || model.Id != id)
            {
                return BadRequest();
            }

            Region region = _repository.Get(id);

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
            Region region = _repository.Delete(id);

            if (region == null)
            {
                return BadRequest();
            }

            return Ok(region);
        }
    }
}
