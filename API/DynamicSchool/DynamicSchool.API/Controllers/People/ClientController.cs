using AutoMapper;
using DynamicSchool.API.Interfaces;
using DynamicSchool.API.Model.Response;
using DynamicSchool.Core.Enum;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DynamicSchool.API.Controllers.People
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IPeopleService _service;
        private readonly IMapper _mapper;


        public ClientController(IPeopleService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var client = await _service.GetClientById(id);

            if (client == null) return NotFound();

            return Ok(client);
        }


        [HttpPost("new")]
        public async Task<IActionResult> Post(ClientRequest client)
        {
            await _service.Add(client);

            return Ok(client);
        }

        [HttpPut("alter")]
        public async Task<IActionResult> Put(ClientRequest client)
        {            

            await _service.Modify(client);

            return Ok(client);

        }

        [HttpPatch("status")]
        public async Task<IActionResult> Patch(ClientRequest client)
        {
            
            await _service.ChangeStatus(client.Id, true);
            
            return Ok(client);

        }
    }
}
