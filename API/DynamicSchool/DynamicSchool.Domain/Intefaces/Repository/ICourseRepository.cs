using DynamicSchool.Domain.DTO.Course;
using DynamicSchool.Domain.Entities.Courses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DynamicSchool.Domain.Inteface.Repository
{
    public interface ICourseRepository
    {
        Task Add(Course couse);
        Task Add(Level level);
        Task Add(Lesson lesson);
        Task Add(Question question);
        Task Edit(Question question);
        Task Add(ResponseQuestion response);
        Task Edit(ResponseQuestion response);
        Task<IEnumerable<CourseDTO>> List(Guid id);
        Task<IEnumerable<LevelDTO>> ListLevel(Guid id);
        Task<IEnumerable<QuestionDTO>> ListQuestion(Guid lessonId);
        Task<IEnumerable<ResponseDTO>> ListResponse(Guid QuestionId);
    }
}
