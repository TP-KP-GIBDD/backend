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
        public IActionResult createAppoint([FromBody] RegServiceInfo serviceInfo)
        {
          

            if (regService.SaveRegistrationService(serviceInfo))
            {
                return Ok();
            }
            
            //if (regService.SaveRegistrationService(serviceInfo))
            //{
            //    return Ok();
            //}

            return BadRequest();
        }
    }
}
