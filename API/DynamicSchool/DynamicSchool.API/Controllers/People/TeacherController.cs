using AutoMapper;
using DynamicSchool.API.Interfaces;
using DynamicSchool.API.Model.Request;
using DynamicSchool.Domain.Entities.People;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DynamicSchool.API.Controllers.People
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly IPeopleService _peopleService;
        private readonly IMapper _mapper;

        public TeacherController(IPeopleService peopleService, IMapper mapper)
        {
            _peopleService = peopleService;
            _mapper = mapper;
        }


        [HttpPost]
        public async Task<ActionResult<Teacher>> Post(TeacherRequest teacher)
        {
            var teacherBuilt = _mapper.Map<Teacher>(teacher);

            await _peopleService.Add(teacherBuilt);

            return teacherBuilt;
        }
    }
}
