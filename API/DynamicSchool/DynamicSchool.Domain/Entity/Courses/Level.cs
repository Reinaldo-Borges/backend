using System.Collections.Generic;

namespace DynamicSchool.Domain.Entity.Courses
{
    public class Level : Entity
    {
        public string Name { get; private set; }
        public string Code { get; private set; }
        private List<Class> _Classes { get; set; }
        public IReadOnlyCollection<Class> Classes => _Classes;
        public Course Course { get; set; }

        public Level(string name, Course course)
        {
            Name = name;
            Course = course;
        }

        public Level SetClasses(List<Class> classes)
        {
            _Classes = classes;
            return this;
        }
    }
}
