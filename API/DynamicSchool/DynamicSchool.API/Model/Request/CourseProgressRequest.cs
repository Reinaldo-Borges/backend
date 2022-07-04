using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicSchool.API.Model.Request
{
    public class CourseProgressRequest : BaseRequest
    {
        public Guid RegistrationId { get; set; }
        public Guid LessonId { get; set; }

    }
}
