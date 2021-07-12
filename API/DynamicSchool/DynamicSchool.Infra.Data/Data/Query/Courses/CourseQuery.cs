using Dapper;
using DynamicSchool.Domain.DTO.Course;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DynamicSchool.Infra.Data.Data.Query.Courses
{
    public class CourseQuery
    {
        private readonly IDbConnection _connection;
        private readonly IDbTransaction _transaction;

        public CourseQuery(IDbConnection connection, IDbTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }
        
        public async Task<IEnumerable<CourseDTO>> List(Guid id)
        {
            var sql = @"select 
		                cs.Id,
		                cs.Name,
		                cs.Description,
		                cs.CreationDate,
		                cs.Status,
		                cs.TeacherId,
                        lv.Id LevelId,
	                    lv.Name LevelName,
	                    lv.Code LevelCode, 
                        lv.CreationDate LevelCreationDate,
	                    lv.Status LevelStatus,
	                    ls.Id LessonId,
	                    ls.Name LessonName,
	                    ls.Description LessonDescription,
	                    ls.Image LessonImage,
                        ls.CreationDate LessonCreationDate,
	                    ls.Status LessonSatus
                from Course cs 
                INNER JOIN Level lv on lv.CourseId = cs.Id 
                INNER JOIN Lesson ls  on ls.LevelId = lv.Id
                where cs.Id = @Id";

            var parametros = new
            {
                Id = id
            };

            return await _connection.QueryAsync<CourseDTO>(sql, parametros, _transaction);
        }
    }
}
