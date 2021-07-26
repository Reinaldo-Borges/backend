using DynamicSchool.Domain.DTO.Course;
using DynamicSchool.Domain.Entities.Courses;
using DynamicSchool.Domain.Inteface.Repository;
using DynamicSchool.Infra.Data.Data.Query.Courses;
using DynamicSchool.Infra.Data.infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DynamicSchool.Infra.Data.infrastructure.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ApplicationContext _context;

        public CourseRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Add(Course course)
        {
             _context.Set<Course>().Add(course);
        }

        public async Task Add(Level level)
        {
            _context.Set<Level>().Add(level);
        }

        public async Task Add(Lesson lesson)
        {
            _context.Set<Lesson>().Add(lesson);         
        }

        public async Task<IEnumerable<CourseDTO>> List(Guid id)
        {
            return await new CourseQuery(_context).List(id);
        }

        public async Task<IEnumerable<LevelDTO>> ListLevel(Guid id)
        {
            return await new LevelQuery(_context).List(id);
        }
    }
}
