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

        public async Task Add(Question question)
        {
            var sql = @"INSERT INTO Question
                               (Id, Code, Description, TypeQuestion, LessonId)
                         VALUES
                               (@Id, @Code, @Description, @TypeQuestion, @LessonId)";

            var parametros = new
            {
                Id = question.Id,
                Code = question.Code,
                Description = question.Description,
                TypeQuestion = (short) question.TypeQuestion,
                LessonId = question.LessonId
            };

            _connection.Execute(sql, parametros, _transaction);
        }

        public async Task Add(ResponseQuestion response)
        {
            var sql = @"INSERT INTO Response
                               (Id, Description, IsTrue, NumberOrder, Reason, QuestionId)
                         VALUES
                               (@Id, @Description, @IsTrue, @Order, @Reason, @QuestionId)";

            var parametros = new
            {
                Id = response.Id,              
                Description = response.Description,
                IsTrue = response.IsTrue,
                Order = response.Order,
                Reason = response.Reason,
                QuestionId = response.QuestionId
            };

            _connection.Execute(sql, parametros, _transaction);
        }

        public async Task Edit(Question question)
        {
            var sql = "UPDATE Question SET Description = @Description WHERE Id = @Id";

            var parametros = new
            {
                Id = question.Id,
                Description = question.Description
            };

            _connection.Execute(sql, parametros, _transaction);
        }

        public async Task Edit(ResponseQuestion response)
        {
            var sql = @"UPDATE Response
                             SET Description = @Description, 
                                 IsTrue = @IsTrue, 
                                 Reason = @Reason
                         WHERE  Id = @Id";

            var parametros = new
            {
                Id = response.Id,
                Description = response.Description,
                IsTrue = response.IsTrue,       
                Reason = response.Reason         
            };

            _connection.Execute(sql, parametros, _transaction);
        }
    }
}
