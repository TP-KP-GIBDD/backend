using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistrationAppointService.Models;
using RegistrationAppointService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationAppointService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        IRegAppointService regService;
        public MainController(IRegAppointService regService)
        {
            this.regService = regService;
        }

        [HttpPost]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult createAppoint([FromBody] RegServiceInfo serviceInfo)
        {
          
            if (regService.SaveRegistrationService(serviceInfo))
            {
                return Ok();
            }

            return BadRequest();
        }

        [HttpGet("GetAllAppoints")]
        public IActionResult GetAllAppoints()
        {
            return Ok(regService.GetAllRegAppoints());
        }

        [HttpGet("GetAppointsByCarOwnerId/{id}")]
        public IActionResult GetAppointsByCarOwnerId(int id)
        {
            // Логика поиска carOwner из микросервиса автовладелец

            return Ok(regService.GetRegAppointsByCarOwnerId(id));
        }

        [HttpGet("GetAppointById/{id}")]
        public IActionResult GetAppointById(int id)
        {
            var appoint = regService.GetRegAppointById(id);

            if (appoint == null)
            {
                return NotFound();
            }

            return Ok(appoint);
        }

        [HttpPost("SetStatus/{regAppointId}")]
        public IActionResult SetStatus(int regAppointId, [FromQuery] string status)
        {
            var appoint = regService.GetRegAppointById(regAppointId);

            if (appoint == null)
            {
                return BadRequest(new { errMessage = "Данная запись на услугу не найдена" });
            }

            if (!regService.SetRegAppointStatus(regAppointId, status))
            {
                return BadRequest(new { errMessage = "Произошла ошибка при установке статуса" });
            }

            return Ok(appoint);
        }
    }
}
