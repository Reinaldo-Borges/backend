namespace DynamicSchool.Domain.Entity.Courses
{
    public class Class : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Image { get; set; }
        public Level Level { get; set; }

        public Class(string name, Level level)
        {
            Name = name;
            Level = level;
        }
    }
}
