using DynamicSchool.Domain.Entities.Registrations;
using System.Threading.Tasks;

namespace DynamicSchool.API.Interfaces
{
    public interface IRegistrationService
    {
        Task Add(Registration registration);
        Task Add(CourseProgress courseProgress);
    }
}
