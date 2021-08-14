using DynamicSchool.API.Extensions;
using DynamicSchool.API.Interfaces;
using DynamicSchool.API.Model.Request;
using DynamicSchool.Core.Enum;
using DynamicSchool.Domain.Entities.People;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DynamicSchool.API.Controllers.People
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IPeopleService _peopleService;

        public StudentController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        [HttpPost("new")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Student>> Post(StudentRequest student)
        {
            if (!this.ModelState.IsValid) return BadRequest();

            var studentBuild = student.ToStudent();
            studentBuild.Activate();

            await _peopleService.Add(studentBuild);

            return studentBuild;
        }

    }
}
