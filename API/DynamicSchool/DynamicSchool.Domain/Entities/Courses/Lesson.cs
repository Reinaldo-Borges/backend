using DynamicSchool.Core.DomainObjects;
using System;

namespace DynamicSchool.Domain.Entities.Courses
{
    public class Lesson : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Image { get; set; }
        public Guid LevelId { get; set; }

        public Lesson(string name, Guid levelId)
        {
            Name = name;
            LevelId = levelId;
        }

        public Lesson SetDescription(string description)
        {
            Description = description;
            return this;
        }

        public Lesson SetImage(string image)
        {
            Image = image;
            return this;
        }

        private void Validate()
        {
            Assertion.HasValue(Name, "The property Name can't be void");
            Assertion.IsFalse(LevelId == Guid.Empty, "The Level can't be null");            
        }
    }
}
