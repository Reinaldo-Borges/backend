using DynamicSchool.Domain.Entities.People;
using System;

namespace DynamicSchool.API.Model.Request
{
    public class CourseRequest : BaseRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid TeacherId { get; set; }
    }
}
