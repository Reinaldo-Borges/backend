using System;

namespace DynamicSchool.API.Model.Request
{
    public class RegistrationRequest
    {
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
    }
}
