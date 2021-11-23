using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistrationAppointService.Services;
using RegistrationAppointService.Services.Interfaces;
using RegistrationAppointService.Repositories.Interfaces;
using RegistrationAppointService.Models;

namespace RegistrationAppointService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionOfficeController : ControllerBase
    {
        IRegionOfficeService<int> service;
        IRepository<Region, int> regionRepo;

        public RegionOfficeController(IRegionOfficeService<int> service, IRepository<Region, int> regionRepo)
        {
            this.service = service;
            this.regionRepo = regionRepo;
        }

        [HttpGet("{id}")]
        public IActionResult GetOfficesByRegionId(int id)
        {
            if(regionRepo.Get(id) == null)
            {
                return NotFound();
            }

            return Ok(service.GetOfficesByRegionId(id));
        }
    }
}
