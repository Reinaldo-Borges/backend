namespace DynamicSchool.Domain.Entity.People
{
    public class Profile : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Profile(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
