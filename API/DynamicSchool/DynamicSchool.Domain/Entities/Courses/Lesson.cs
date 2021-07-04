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
    }
}
