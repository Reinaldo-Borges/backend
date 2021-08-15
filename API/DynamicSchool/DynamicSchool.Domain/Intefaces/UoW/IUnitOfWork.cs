using DynamicSchool.Domain.Inteface.Repository;
using System.Threading.Tasks;

namespace DynamicSchool.Domain.Inteface.UoW
{
    public interface IUnitOfWork
    {
        IPeopleRepository PeopleRepository { get; }
        ICourseRepository CourseRepository { get; }
        IRegistrationRepository RegistrationRepository { get; }

        void Commit();   

    }
}
