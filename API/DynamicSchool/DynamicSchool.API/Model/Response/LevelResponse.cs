using DynamicSchool.Core.Enum;
using System;
using System.Collections.Generic;

namespace DynamicSchool.API.Model.Response
{
    public class LevelResponse 
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Guid CourseId { get; set; }
        public DateTime CreationDate { get; set; }
        public StatusEntityEnum Status { get; set; }
        public List<LessonResponse> Lessons { get; set; }
    }
}
