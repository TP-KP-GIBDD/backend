using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistrationAppointService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationAppointService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DateTimeController : ControllerBase
    {
        IDateTimeService service;

        public DateTimeController(IDateTimeService service)
        {
            this.service = service;
        }

        [HttpGet("GetTimesByDate/{date}")]
        public IActionResult GetTimesByDate(string date)
        {
            try
            {
                if (service.GetTimesByDate(date).Count() == 0)
                {
                    return NotFound();
                }

                return Ok(service.GetTimesByDate(date));
            }
            catch
            {
                return BadRequest();
            }

        }
    }
}
