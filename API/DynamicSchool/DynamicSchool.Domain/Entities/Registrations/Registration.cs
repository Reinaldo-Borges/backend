using DynamicSchool.Core.DomainObjects;
using DynamicSchool.Domain.Entities.Courses;
using DynamicSchool.Domain.Entities.People;
using DynamicSchool.Domain.Inteface;
using System;

namespace DynamicSchool.Domain.Entities.Registrations
{
    public class Registration : Entity, IAggregateRoot
    {
        public Guid StudentId { get; private set; }
        public Student Student { get; private set; }
        public Guid CourseId { get; private set; }
        public Course Course { get; private set; }

        public Registration() { }
        public Registration(Guid studentId, Guid courseId)
        {
            StudentId = studentId;
            CourseId = courseId;

            Validate();
        }

        private void Validate()
        {
            Assertion.IsTrue(StudentId != Guid.Empty, "The Student can't be null.");
            Assertion.IsTrue(CourseId != Guid.Empty, "The Course can't be null.");
        }
    }
}
