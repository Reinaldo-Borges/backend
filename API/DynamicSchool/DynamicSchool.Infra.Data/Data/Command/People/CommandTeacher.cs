using Dapper;
using DynamicSchool.Domain.Entities.People;
using System.Data;
using System.Threading.Tasks;

namespace DynamicSchool.Infra.Data.Data.Command.People
{
    public class CommandTeacher
    {
        private readonly IDbConnection _connection;
        private readonly IDbTransaction _transaction;

        public CommandTeacher(IDbConnection connection, IDbTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }

        public async Task Add(Teacher teacher)
        {
            var sql = @"INSERT INTO Teacher
                               (Id, TeacherDocument, Name, Email, Cellphone, Birthday, ClientOrigin)
                         VALUES
                               (@Id, @TeacherDocument, @Name, @Email, @Cellphone, @Birthday, @ClientOrigin)";

            var parametros = new
            {
                Id = teacher.Id,
                TeacherDocument = teacher.Document,
                Name = teacher.Name,
                Email = teacher.Email,
                CellPhone = teacher.Cellphone,
                Birthday = teacher.BirthDay,      
                ClientOrigin = teacher.ClientOrigin
            };

            _connection.Execute(sql, parametros, _transaction);
        }
    }
}
