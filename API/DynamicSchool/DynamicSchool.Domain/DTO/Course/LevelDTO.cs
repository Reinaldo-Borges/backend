using System;

namespace DynamicSchool.Domain.DTO.Course
{
    public class LevelDTO
    {
        public Guid LevelId { get; set; }
        public string LevelName { get;  set; }
        public string Code { get;  set; }
        public Guid CourseId { get; set; }
        public DateTime LevelCreationDate { get; set; }
        public int LevelStatus { get; set; }
        public Guid LessonId { get; set; }
        public string LessonName { get; private set; }
        public string Description { get; private set; }
        public string Image { get; set; }
        public DateTime LessonCreationDate { get; set; }
        public int LessonStatus { get; set; }

    }
}