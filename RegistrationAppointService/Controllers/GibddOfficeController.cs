using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistrationAppointService.Repositories.Interfaces;
using RegistrationAppointService.Models;

namespace RegistrationAppointService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GibddOfficeController : ControllerBase
    {
        IRepository<GibddOffice, int> repository;

        public GibddOfficeController(IRepository<GibddOffice, int> repository)
        {
            this.repository = repository;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            GibddOffice region = repository.Get(id);

            if (region == null)
            {
                return NotFound();
            }

            return Ok(region);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(repository.GetAll());
        }

        [HttpPost]
        public IActionResult Create([FromBody] GibddOffice model)
        {
            if (model == null)
            {
                return BadRequest();
            }

            repository.Create(model);
            return Ok(model);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] GibddOffice model)
        {
            if (model == null || model.Id != id)
            {
                return BadRequest();
            }

            GibddOffice region = repository.Get(id);

            if (region == null)
            {
                return NotFound();
            }

            repository.Update(model);
            return Ok(region);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            GibddOffice office = repository.Delete(id);

            if (office == null)
            {
                return BadRequest();
            }

            return Ok(office);
        }
    }
}
