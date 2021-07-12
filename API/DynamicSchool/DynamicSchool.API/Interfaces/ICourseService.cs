using DynamicSchool.Domain.DTO.Course;
using DynamicSchool.Domain.Entities.Courses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DynamicSchool.API.Interfaces
{
    public interface ICourseService
    {
        Task Add(Course course);
        Task Add(Level level);
        Task Add(Lesson lesson);       
        Task<IEnumerable<CourseDTO>> List(Guid id);
        Task<IEnumerable<LevelDTO>> ListLevel(Guid id);
    }
}
