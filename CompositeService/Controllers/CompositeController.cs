using CompositeService.Model;
using CompositeService.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace CompositeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompositeController : ControllerBase
    {
        IHttpClientFactory factory;

        public CompositeController(IHttpClientFactory factory)
        {
            this.factory = factory;
        }

        [HttpGet("/GetRegistrationAppoints/{id}")]
        public async Task<IActionResult> GetRegistrationAppointById(int id)
        {

            var request = new HttpRequestMessage(HttpMethod.Get,
            "https://api.github.com/repos/dotnet/AspNetCore.Docs/branches");
            request.Headers.Add("Accept", "application/vnd.github.v3+json");
            request.Headers.Add("User-Agent", "HttpClientFactory-Sample");

            var client = factory.CreateClient();

            var response = await client.SendAsync(request);
            
            CarOwnerRegAppoint carOwnerRegAppoint = null;

            if (response.IsSuccessStatusCode)
            {
               
                using var responseStream = await response.Content.ReadAsStreamAsync();
                carOwnerRegAppoint = await JsonSerializer.DeserializeAsync
                    <CarOwnerRegAppoint>(responseStream);
            }

            return Ok(carOwnerRegAppoint);
        }
    }
}
