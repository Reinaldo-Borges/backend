using DynamicSchool.Domain.Entity.Courses;
using DynamicSchool.Domain.Entity.People;
using DynamicSchool.Domain.Inteface;

namespace DynamicSchool.Domain.Entity.Registration
{
    public class Registration : Entity, IAggregateRoot
    {
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
