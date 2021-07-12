using DynamicSchool.API.Model.Response;
using DynamicSchool.Core.Enum;
using DynamicSchool.Domain.DTO.Course;
using System.Collections.Generic;
using System.Linq;

namespace DynamicSchool.API.Extensions
{
    public static class DtoToResponseExtensions
    {
        public static LevelResponse ToLevelResponse(this IEnumerable<LevelDTO> levelDTOs)
        {
            var originalList = levelDTOs;
            var level = levelDTOs.GroupBy(gb => new { gb.LevelId, gb.LevelName, gb.Code, gb.CourseId, gb.LevelStatus, gb.LevelCreationDate })
                .Select(s => new LevelResponse()
                {
                    Id = s.Key.LevelId,
                    Name = s.Key.LevelName,
                    Code = s.Key.Code,
                    CourseId = s.Key.CourseId,
                    CreationDate = s.Key.LevelCreationDate,
                    Status = (StatusEntityEnum) s.Key.LevelStatus,
                    Lessons = originalList.Select(l => new LessonResponse { 
                        Id = l.LessonId,
                        Name = l.LessonName,
                        Description = l.Description,
                        Image = l.Image,
                        LevelId = l.LevelId,
                        CreationDate = l.LessonCreationDate,
                        Status = (StatusEntityEnum) l.LessonStatus
                    }).ToList()
                }).First();

            return level;
        }

        public static CourseResponse ToCourseResponse(this IEnumerable<CourseDTO> courses)
        {
            var levels = courses;
            var lessons = courses;
            var course = courses.GroupBy(gb => new { gb.Id, gb.Name, gb.Description, gb.CreationDate, gb.Status, gb.TeacherId })
                .Select(s => new CourseResponse()
                {
                    Id = s.Key.Id,
                    Name = s.Key.Name,
                    Description = s.Key.Description,                   
                    CreationDate = s.Key.CreationDate,
                    Status = (StatusEntityEnum) s.Key.Status,
                    Levels = levels.GroupBy(b => new { b.LevelId, b.LevelName, b.LevelCode, b.LevelCreationDate, b.LevelStatus})
                    .Select(l => new LevelResponse()
                    {
                        Id = l.Key.LevelId,
                        Name = l.Key.LevelName,
                        Code = l.Key.LevelCode,
                        CreationDate = l.Key.LevelCreationDate,
                        Status = (StatusEntityEnum) l.Key.LevelStatus,
                        Lessons = lessons.Select(ls => new LessonResponse() { 
                            Id = ls.LessonId,
                            Name = ls.LessonName,
                            Description = ls.LessonDescription,
                            Image = ls.LessonImage,
                            CreationDate = ls.LessonCreationDate,
                            Status = (StatusEntityEnum) ls.LessonStatus
                        }).ToList()
                    }).ToList()
                }).First();

            return course;
        }
    }
}

