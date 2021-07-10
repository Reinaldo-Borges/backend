using DynamicSchool.Core.DomainObjects;
using DynamicSchool.Domain.Inteface;
using System;

namespace DynamicSchool.Domain.Entities.Courses
{
    public class Course : Entity, IAggregateRoot
    {      
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid TeacherId { get; set; } 

        public Course(string name, Guid teacherId)
        {
            Name = name;
            TeacherId = teacherId;

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
            Assertion.IsTrue(TeacherId == Guid.Empty, "The property TeacherId can't be void");
        }
    }
}
