using DynamicSchool.API.Interfaces;
using DynamicSchool.Domain.DTO.People;
using DynamicSchool.Domain.Inteface.Repository;
using DynamicSchool.Domain.Inteface.UoW;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
