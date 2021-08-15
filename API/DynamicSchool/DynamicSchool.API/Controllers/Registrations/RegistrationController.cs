using DynamicSchool.API.Extensions;
using DynamicSchool.API.Interfaces;
using DynamicSchool.API.Model.Request;
using DynamicSchool.Domain.Entities.Registrations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DynamicSchool.API.Controllers.Registrations
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegistrationService _service;

        public RegistrationController(IRegistrationService service)
        {
            _service = service;
        }

        [HttpPost("new")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<bool>> Post(RegistrationRequest resgistrationRequest)
        {
            if (resgistrationRequest.CourseId == Guid.Empty || resgistrationRequest.StudentId == Guid.Empty)
                return BadRequest();

            var registration = resgistrationRequest.ToRegistration();
            registration.SetNew<Registration>();

            await _service.Add(registration);

            return Ok(true);
        }
    }
}
