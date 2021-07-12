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
        Task<IEnumerable<CourseDTO>> List(Guid id);
        Task<IEnumerable<LevelDTO>> ListLevel(Guid id);
    }
}
