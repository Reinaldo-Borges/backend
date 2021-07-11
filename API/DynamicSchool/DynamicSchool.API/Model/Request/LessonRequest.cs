using System;

namespace DynamicSchool.API.Model.Request
{
    public class LessonRequest : BaseRequest
    {
        public string Name { get;  set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Guid LevelId { get; set; }
    }
}
