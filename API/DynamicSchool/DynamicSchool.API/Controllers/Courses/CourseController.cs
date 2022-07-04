using AutoMapper;
using DynamicSchool.API.Extensions;
using DynamicSchool.API.Interfaces;
using DynamicSchool.API.Model.Request;
using DynamicSchool.API.Model.Response;
using DynamicSchool.Domain.DTO.Course;
using DynamicSchool.Domain.Entities.Courses;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [HttpPost("new")]
        [ProducesResponseType(typeof(Course), StatusCodes.Status201Created)]
        [ProducesResponseType((int)StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Course>> Create(CourseRequest course)
        { 
            var courseBuilt = course.ToCourse();           

            await _courseService.Add(courseBuilt);

            return CreatedAtAction("Post", courseBuilt);
        }

        [HttpPost("level/new")]
        [ProducesResponseType(typeof(Level), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Level>> Create(LevelRequest level)
        {
            var levelBuilt = level.ToLevel();

            await _courseService.Add(levelBuilt);

            return CreatedAtAction("Post", levelBuilt);
        }

        [HttpPost("lesson/new")]
        [ProducesResponseType(typeof(CourseResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Lesson>> Create(LessonRequest lesson)
        {
            var lessonBuilt = lesson.ToLesson();

            _courseService.Add(lessonBuilt);

            return lessonBuilt;
        }

        [HttpPost("question/new")]
        [ProducesResponseType(typeof(QuestionResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<QuestionRequest>> Create(QuestionRequest question)
        {
            if(question.Id != Guid.Empty && question.LessonId == Guid.Empty) return BadRequest();

            var questionBuilt = question.ToQuestion();
            _courseService.Add(questionBuilt);

            return question;
        }

        [HttpPatch("question/modify")]
        [ProducesResponseType(typeof(QuestionResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<QuestionRequest>> Update(QuestionRequest question)
        {
            if (question.Id == Guid.Empty) return BadRequest();

            var questionBuilt = question.ToQuestion();

            _courseService.Edit(questionBuilt);

            return question;
        }

        [HttpPost("response/new")]
        [ProducesResponseType(typeof(ResponseQuestion), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Create(ResponseRequest responses)
        {
            
            var responseBuilt = responses.ToResponse(); 
            
             _courseService.Add(responseBuilt);   


            return Ok(responseBuilt);
        }

        [HttpPatch("response/modify")]
        [ProducesResponseType(typeof(ResponseQuestion), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Edit(ResponseRequest responses)
        {
            if (responses.Id == Guid.Empty) return BadRequest();

            var responseBuilt = responses.ToResponse();

            _courseService.Edit(responseBuilt);


            return Ok(responseBuilt);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(LevelResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<CourseResponse>>> GetCourse(Guid id)
        {
            if (id == Guid.Empty) return BadRequest();

            var courses = await _courseService.List(id);

            if (!courses.Any()) return NotFound();

            var course = courses.ToCourseResponse();
            return course.ToList();
        }

        [HttpGet("level/{id}")]
        [ProducesResponseType(typeof(LevelResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<LevelResponse>> GetLevel(Guid id)
        {
            if (id == Guid.Empty) return BadRequest();

            var levels = await _courseService.ListLevel(id);

            if (!levels.Any()) return NotFound();

            var level = levels.ToLevelResponse();
            return level;
        }

        [HttpGet("question/{lessonId}")]
        [ProducesResponseType(typeof(IEnumerable<QuestionDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<QuestionDTO>>> GetQuestion(Guid lessonId)
        {
            if (lessonId == Guid.Empty) return BadRequest();

            var questions = await _courseService.ListQuestion(lessonId);

            if (!questions.Any()) return NotFound();

            return questions.ToList();
        }


        [HttpGet("response/{questionId}")]
        [ProducesResponseType(typeof(IEnumerable<ResponseDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<ResponseDTO>>> GetResponse(Guid questionId)
        {
            if (questionId == Guid.Empty) return BadRequest();

            var responses = await _courseService.ListResponse(questionId);

            if (!responses.Any()) return NotFound();

            return responses.ToList();
        }
    }
}
