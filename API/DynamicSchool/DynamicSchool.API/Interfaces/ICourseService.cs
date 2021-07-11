using DynamicSchool.Domain.Entities.Courses;
using System.Threading.Tasks;

namespace DynamicSchool.API.Interfaces
{
    public interface ICourseService
    {
        Task Add(Course course);
        Task Add(Level level);
        Task Add(Lesson lesson);
    }
}
