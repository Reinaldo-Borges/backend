using DynamicSchool.Domain.DTO.Course;
using DynamicSchool.Domain.Entities.Courses;
using DynamicSchool.Domain.Inteface.Repository;
using DynamicSchool.Infra.Data.Data.Command.Courses;
using DynamicSchool.Infra.Data.Data.Query.Courses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DynamicSchool.Infra.Data.infrastructure.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly IDbConnection _context;
        private IDbTransaction _transaction;

        public CourseRepository(IDbConnection context, IDbTransaction transaction)
        {
            _context = context;
            _transaction = transaction;
        }

        public async Task Add(Course course)
        {
            await new CourseCommand(_context, _transaction).Add(course);
        }

        public async Task Add(Level level)
        {
            await new CourseCommand(_context, _transaction).Add(level);
        }

        public async Task Add(Lesson lesson)
        {
            await new CourseCommand(_context, _transaction).Add(lesson);
        }

        public async Task Add(Question question)
        {
            await new CourseCommand(_context, _transaction).Add(question);
        }

        public async Task Edit(Question question)
        {
            await new CourseCommand(_context, _transaction).Edit(question);
        }

        public async Task Add(ResponseQuestion response)
        {
            await new CourseCommand(_context, _transaction).Add(response);
        }

        public async Task Edit(ResponseQuestion response)
        {
            await new CourseCommand(_context, _transaction).Edit(response);
        }

        public async Task<IEnumerable<CourseDTO>> List(Guid id)
        {
            return await new CourseQuery(_context, _transaction).List(id);
        }

        public async Task<IEnumerable<LevelDTO>> ListLevel(Guid id)
        {
            return await new LevelQuery(_context, _transaction).List(id);
        }

        public async Task<IEnumerable<QuestionDTO>> ListQuestion(Guid lessonId)
        {
            return await new QuestionQuery(_context, _transaction).List(lessonId);
        }

        public async Task<IEnumerable<ResponseDTO>> ListResponse(Guid questionId)
        {
            return await new ResponseQuery(_context, _transaction).List(questionId);
        }
    }
}
