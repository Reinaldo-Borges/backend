using DynamicSchool.Core.DomainObjects;
using DynamicSchool.Domain.Entities.People;
using DynamicSchool.Domain.Inteface;

namespace DynamicSchool.Domain.Entities.Courses
{
    public class Course : Entity, IAggregateRoot
    {      
        public string Name { get; set; }
        public string Description { get; set; }
        public Teacher Teacher { get; set; } 

        public Course(string name, Teacher teacher)
        {
            Name = name;
            Teacher = teacher;

            Validate();
        }

        public Course SetDescription(string description)
        {
            Assertion.HasValue(Description, "The property Description can't be void");

            Description = description;
            return this;
        }

        private void Validate()
        {
            Assertion.HasValue(Name, "The property Name can't be void");
            Assertion.IsNotNull(Teacher, "The Taecher can't be null");
        }
    }
}
