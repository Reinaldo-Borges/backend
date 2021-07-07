using DynamicSchool.API.Interfaces;
using DynamicSchool.API.Model.Response;
using DynamicSchool.Domain.Entities.People;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DynamicSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleService _service;

        public PeopleController(IPeopleService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var client = await _service.GetClientById(id);

            if (client == null) return NotFound();

            return Ok(client);
        }


        [HttpPost]
        public async Task<IActionResult> Post(ClientRequest client)
        {


            await _service.Add(client);

            return Ok(client);
        }
    }
}
