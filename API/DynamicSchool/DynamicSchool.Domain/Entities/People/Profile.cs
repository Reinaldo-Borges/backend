using DynamicSchool.Core.DomainObjects;

namespace DynamicSchool.Domain.Entities.People
{
    public class Profile : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Profile(string name, string description)
        {
            Name = name;
            Description = description;

            Validate();
        }

        private void Validate()
        {
            Assertion.HasValue(Name, "The property Name can't be void");
            Assertion.HasValue(Description, "The property Description can't be void");
        }
    }
}
