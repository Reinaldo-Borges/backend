using Dapper;
using DynamicSchool.Domain.DTO.Course;
using DynamicSchool.Domain.Entities.Courses;
using DynamicSchool.Infra.Data.infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DynamicSchool.Infra.Data.Data.Query.Courses
{
    public class CourseQuery
    {
        private readonly ApplicationContext _context;

        public CourseQuery(ApplicationContext context)
        {
            _context = context;
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
	                    ls.Status LessonStatus,
                        ls.LevelId LessonLevelId
                from Course cs 
                INNER JOIN Level lv on lv.CourseId = cs.Id 
                LEFT JOIN Lesson ls  on ls.LevelId = lv.Id
                where cs.Id = @Id";

            var parametros = new
            {
                Id = id
            };

            var course = await _context.Database.GetDbConnection()
                .QueryAsync<CourseDTO>(sql, parametros);

            return course;

        }    
     }
}
