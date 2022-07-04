using Dapper;
using DynamicSchool.Domain.DTO.Course;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DynamicSchool.Infra.Data.Data.Query.Courses
{
    public class QuestionQuery
    {
        private readonly IDbConnection _connection;
        private readonly IDbTransaction _transaction;

        public QuestionQuery(IDbConnection connection, IDbTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }

        public async Task<IEnumerable<QuestionDTO>> List(Guid lessonId)
        {
            var sql = @"select 
	                        q.Id,
	                        q.Code,
	                        q.Description,                          
	                        q.TypeQuestion,
	                        q.CreationDate,
	                        q.LessonId	               
                        from Question q 
                        where q.LessonId = @Id
                        order by q.CreationDate desc";


            var parametros = new
            {
                Id = lessonId
            };

            return await _connection.QueryAsync<QuestionDTO>(sql, parametros, _transaction);
        }
    }
}
