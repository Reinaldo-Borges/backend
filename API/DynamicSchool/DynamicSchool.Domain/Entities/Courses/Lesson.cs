using DynamicSchool.Core.DomainObjects;

namespace DynamicSchool.Domain.Entities.Courses
{
    public class Lesson : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Image { get; set; }
        public Level Level { get; set; }

        public Lesson(string name, Level level)
        {
            Name = name;
            Level = level;
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
            Assertion.IsNotNull(Level, "The Level can't be null");            
        }
    }
}
