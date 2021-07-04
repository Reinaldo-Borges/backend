using DynamicSchool.Core.DomainObjects;
using DynamicSchool.Domain.Entities.Courses;
using DynamicSchool.Domain.Entities.People;
using DynamicSchool.Domain.Inteface;

namespace DynamicSchool.Domain.Entities.Registrations
{
    public class Registration : Entity, IAggregateRoot
    {
        public Student Student { get; private set; }
        public Course Course { get; private set; }

        public Registration(Student student, Course course)
        {
            Student = student;
            Course = course;

            Validate();
        }

        private void Validate()
        {

        }
    }
}
