using AutoMapper;
using DynamicSchool.API.Interfaces;
using DynamicSchool.API.Model.Request;
using DynamicSchool.Domain.Entities.Courses;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DynamicSchool.API.Controllers.People
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;

        public CourseController(ICourseService courseService, IMapper mapper)
        {
            _courseService = courseService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<Course>> Post(CourseRequest course)
        {
            var courseBuilt = _mapper.Map<Course>(course);

            _courseService.Add(courseBuilt);

            return courseBuilt;
        }
    }
}
