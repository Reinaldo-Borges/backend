using Dapper;
using DynamicSchool.Domain.DTO.Course;
using DynamicSchool.Infra.Data.infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DynamicSchool.Infra.Data.Data.Query.Courses
{
    public class LevelQuery
    {
        private readonly ApplicationContext _context;

        public LevelQuery(ApplicationContext context)
        {
            _context = context;
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

            return await _context.Database.GetDbConnection()
                .QueryAsync<LevelDTO>(sql, parametros);
        }       
    }
}
