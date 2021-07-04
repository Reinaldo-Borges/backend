using DynamicSchool.Core.DomainObjects;
using DynamicSchool.Domain.Entities.Courses;

namespace DynamicSchool.Domain.Entities.Registrations
{
    public class CourseProgress : Entity
    {
        public  Registration Registration { get; set; }
        public Lesson Lesson { get; set; }

        public CourseProgress(Registration registration, Lesson lesson)
        {
            Registration = registration;
            Lesson = lesson;
        }

        private void Validate()
        {

        }
    }
}
