using DynamicSchool.Core.DomainObjects;
using System;
using System.Collections.Generic;

namespace DynamicSchool.Domain.Entities.Courses
{
    public class Level : Entity
    {
        public string Name { get; private set; }
        public string Code { get; private set; }
        private List<Lesson> _lessons { get; set; }
        public IReadOnlyCollection<Lesson> Classes => _lessons;
        public Guid CourseId { get; set; }

        public Level(string name, Guid courseId)
        {
            Name = name;
            CourseId = courseId;
        }

        public Level SetLesson(List<Lesson> lessons)
        {
            _lessons = lessons;
            return this;
        }

        public Level SetCode(string code)
        {
            Code = code;
            return this;
        }

        private void Validate()
        {
            Assertion.HasValue(Name, "The property Name can't be void");
            Assertion.IsFalse(CourseId == Guid.Empty, "The Course can't be null");
        }
    }
}
