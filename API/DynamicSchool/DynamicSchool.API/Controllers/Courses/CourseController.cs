using AutoMapper;
using DynamicSchool.API.Extensions;
using DynamicSchool.API.Interfaces;
using DynamicSchool.API.Model.Request;
using DynamicSchool.Domain.Entities.Courses;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DynamicSchool.API.Controllers.Courses
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

        [HttpPost("/new")]
        public async Task<ActionResult<Course>> Create(CourseRequest course)
        {
            var courseBuilt = course.ToCourse();

            _courseService.Add(courseBuilt);

            return courseBuilt;
        }

        [HttpPost("/level")]
        public async Task<ActionResult<Level>> Create(LevelRequest level)
        {
            var levelBuilt = level.ToLevel();

            _courseService.Add(levelBuilt);

            return levelBuilt;
        }

        [HttpPost("/lesson")]
        public async Task<ActionResult<Lesson>> Create(LessonRequest lesson)
        {
            var lessonBuilt = lesson.ToLesson();

            _courseService.Add(lessonBuilt);

            return lessonBuilt;
        }
    }
}
