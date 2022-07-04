using Dapper;
using DynamicSchool.Domain.DTO.Course;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DynamicSchool.Infra.Data.Data.Query.Courses
{
    public class LevelQuery
    {
        private readonly IDbConnection _connection;
        private readonly IDbTransaction _transaction;

        public LevelQuery(IDbConnection connection, IDbTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }

        public async Task<IEnumerable<LevelDTO>> List(Guid id)
        {
            var sql = @"select 
                       lv.Id LevelId,
	                   lv.Name LevelName,
	                   lv.Code,	   
	                   lv.CourseId,
                       lv.CreationDate LevelCreationDate,
	                   lv.Status LevelStatus,
	                   ls.Id LessonId,
	                   ls.Name LessonName,
	                   ls.Description,
	                   ls.Image,
                       ls.CreationDate LessonCreationDate,
	                   ls.Status LessonStatus
                from Level lv 
                INNER JOIN Lesson ls  on ls.LevelId = lv.Id
                where lv.Id = @Id";

            var parametros = new
            {
                Id = id
            };

            return await _connection.QueryAsync<LevelDTO>(sql, parametros, _transaction);
        }
    }
}
