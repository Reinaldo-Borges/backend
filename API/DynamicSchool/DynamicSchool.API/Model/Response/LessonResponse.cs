using DynamicSchool.Core.Enum;
using System;

namespace DynamicSchool.API.Model.Response
{
    public class LessonResponse
    {
        public Guid Id { get; set; }
        public string Name { get;  set; }
        public string Description { get;  set; }
        public string Image { get; set; }
        public Guid LevelId { get; set; }
        public DateTime CreationDate { get; set; }
        public StatusEntityEnum Status { get; set; }

    }
}
