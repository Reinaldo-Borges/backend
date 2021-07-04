using DynamicSchool.Domain.Entity.People;
using DynamicSchool.Domain.Inteface;

namespace DynamicSchool.Domain.Entities.Courses
{
    public class Course : Entity, IAggregateRoot
    {      
        public string Name { get; set; }
        public string Description { get; set; }
        public Teacher Teacher { get; set; } 

        public Course(string name, Teacher teacher)
        {
            Name = name;
            Teacher = teacher;
        }

        public Course SetDescription(string description)
        {
            Description = description;
            return this;
        }
    }
}
