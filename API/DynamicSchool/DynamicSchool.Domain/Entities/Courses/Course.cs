using DynamicSchool.Core.DomainObjects;
using DynamicSchool.Domain.Entities.Registrations;
using DynamicSchool.Domain.Inteface;
using System;
using System.Collections.Generic;

namespace DynamicSchool.Domain.Entities.Courses
{
    public class Course : Entity, IAggregateRoot
    {      
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid TeacherId { get; set; }
        public ICollection<Registration> Registrations { get; } = new List<Registration>();

        public Course(string name, Guid teacherId)
        {
            Name = name;
            TeacherId = teacherId;

            Validate();
        }

        public Course SetDescription(string description)
        {  
            Description = description;
            return this;
        }

        private void Validate()
        {
            Assertion.HasValue(Name, "The property Name can't be void");
            Assertion.IsTrue(TeacherId != Guid.Empty, "The property TeacherId can't be void");
        }
    }
}
