using System;

namespace DynamicSchool.Domain.DTO.Course
{
    public class CourseDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public int Status { get; set; }
        public Guid TeacherId { get; set; }
        public Guid LevelId { get; set; }
        public string LevelName { get; set; }
        public string LevelCode { get; set; }        
        public DateTime LevelCreationDate { get; set; }
        public int LevelStatus { get; set; }
        public Guid LessonId { get; set; }
        public string LessonName { get;  set; }
        public string LessonDescription { get; set; }
        public string LessonImage { get; set; }
        public DateTime LessonCreationDate { get; set; }
        public int LessonStatus { get; set; }
    }
}
