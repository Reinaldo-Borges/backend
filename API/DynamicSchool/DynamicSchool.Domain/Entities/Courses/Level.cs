using DynamicSchool.Core.DomainObjects;
using System.Collections.Generic;

namespace DynamicSchool.Domain.Entities.Courses
{
    public class Level : Entity
    {
        public string Name { get; private set; }
        public string Code { get; private set; }
        private List<Lesson> _lessons { get; set; }
        public IReadOnlyCollection<Lesson> Classes => _lessons;
        public Course Course { get; set; }

        public Level(string name, Course course)
        {
            Name = name;
            Course = course;
        }

        public Level SetClasses(List<Lesson> lessons)
        {
            _lessons = lessons;
            return this;
        }

        private void Validate()
        {
            Assertion.HasValue(Name, "The property Name can't be void");
            Assertion.IsNotNull(Course, "The Course can't be null");
        }
    }
}
