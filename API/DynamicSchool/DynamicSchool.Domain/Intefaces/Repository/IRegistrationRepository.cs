using DynamicSchool.Domain.Entities.Registrations;
using System.Threading.Tasks;

namespace DynamicSchool.Domain.Inteface.Repository
{
    public interface IRegistrationRepository 
    {
        Task Add(Registration registration);
        Task Add(CourseProgress courseProgress);
    }
}
