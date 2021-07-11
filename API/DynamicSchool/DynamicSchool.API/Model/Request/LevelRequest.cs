using System;

namespace DynamicSchool.API.Model.Request
{
    public class LevelRequest : BaseRequest
    {
        public string Name { get;  set; }
        public string Code { get;  set; }   
        public Guid CourseId { get; set; }
    }
}
