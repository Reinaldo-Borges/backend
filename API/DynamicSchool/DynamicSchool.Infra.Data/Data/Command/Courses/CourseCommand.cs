using Dapper;
using DynamicSchool.Domain.Entities.Courses;
using System.Data;
using System.Threading.Tasks;

namespace DynamicSchool.Infra.Data.Data.Command.Courses
{
    public class CourseCommand
    {
        private readonly IDbConnection _connection;
        private readonly IDbTransaction _transaction;

        public CourseCommand(IDbConnection connection, IDbTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }

        public async Task Add(Course course)
        {
            var sql = @"INSERT INTO Course
                               (Id, Name, Description, TeacherId)
                         VALUES
                               (@Id, @Name, @Description, @TeacherId)";

            var parametros = new
            {
                Id = course.Id,              
                Name = course.Name,
                Description = course.Description,
                TeacherId = course.TeacherId          
            };

            _connection.Execute(sql, parametros, _transaction);
        }

        public async Task Add(Level level)
        {
            var sql = @"INSERT INTO Level   
                               (Id, Name, Code, CourseId)
                         VALUES
                               (@Id, @Name, @Code, @CourseId)";

            var parametros = new
            {
                Id = level.Id,
                Name = level.Name,
                Code = level.Code,
                CourseId = level.CourseId
            };

            _connection.Execute(sql, parametros, _transaction);
        }

        public async Task Add(Lesson lesson)
        {
            var sql = @"INSERT INTO Lesson
                               (Id, Name, Description, Image, LevelId)
                         VALUES
                               (@Id, @Name, @Description, @Image, @LevelId)";

            var parametros = new
            {
                Id = lesson.Id,
                Name = lesson.Name,
                Description = lesson.Description,
                Image = lesson.Image,
                LevelId = lesson.LevelId
            };

            _connection.Execute(sql, parametros, _transaction);
        }
    }
}
