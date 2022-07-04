using DynamicSchool.Core.DomainObjects;
using DynamicSchool.Domain.Entities.Courses;
using System;

namespace DynamicSchool.Domain.Entities.Registrations
{
    public class CourseProgress : Entity
    {
        public  Registration Registration { get; set; }
        public Guid RegistrationId { get; set; }
        public Lesson Lesson { get; set; }
        public Guid LessonId { get; set; }

        public CourseProgress(Guid registrationId, Guid lessonId)
        {
            RegistrationId = registrationId;
            LessonId = lessonId;

            Validate();
        }

        private void Validate()
        {
            Assertion.IsTrue(RegistrationId != Guid.Empty, "The Lesson can't be null.");
            Assertion.IsTrue(LessonId != Guid.Empty, "The Registration can't be null.");
        }
    }
}
