using DynamicSchool.Domain.Entities.Courses;
using System.Threading.Tasks;

namespace DynamicSchool.Domain.Inteface.Repository
{
    public interface ICourseRepository
    {
        Task Add(Course couse);
    }
}
