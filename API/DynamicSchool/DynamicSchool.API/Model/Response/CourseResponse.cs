using DynamicSchool.Core.Enum;
using System;
using System.Collections.Generic;

namespace DynamicSchool.API.Model.Response
{
    public class CourseResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public StatusEntityEnum Status { get; set; }
        public Guid TeacherId { get; set; }
        public List<LevelResponse> Levels { get; set; }
    }
}
