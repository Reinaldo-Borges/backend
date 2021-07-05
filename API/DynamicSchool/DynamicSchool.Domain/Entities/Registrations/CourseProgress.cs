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
            Assertion.IsNotNull(Lesson, "The Lesson can't be null.");
            Assertion.IsNotNull(Registration, "The Registration can't be null.");
        }
    }
}
