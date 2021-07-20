using AutoMapper;
using DynamicSchool.API.Interfaces;
using DynamicSchool.API.Model.Response;
using DynamicSchool.Core.Enum;
using DynamicSchool.Domain.DTO.People;
using Microsoft.AspNetCore.Http;
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

        [ProducesResponseType(typeof(ClientDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("{id}")]
        public async Task<ActionResult<ClientDTO>> Get(Guid id)
        {
            if (id == Guid.Empty) return BadRequest();

            var client = await _service.GetClientById(id);

            if (client == null) return NotFound();

            return Ok(client);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]     
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost("new")]
        public async Task<IActionResult> Post(ClientRequest client)
        {
            if (client.Id == Guid.Empty) return BadRequest();

            await _service.Add(client);

            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPut("modify")]
        public async Task<IActionResult> Put(ClientRequest client)
        {
            if (client.Id == Guid.Empty) return BadRequest();

            await _service.Modify(client);

            return Ok();

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]    
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPatch("status")]
        public async Task<IActionResult> Patch(ClientRequest client)
        {
            if (client.Id == Guid.Empty) return BadRequest();

            await _service.ChangeStatus(client.Id, true);
            
            return Ok();

        }
    }
}
