using DynamicSchool.Domain.Entities.People;
using System;
using System.Threading.Tasks;

namespace DynamicSchool.Domain.Inteface.Repository
{
    public interface IPeopleRepository
    {
        Task Add(Client client);
        Task Modify(Client client);
        Task<Client> GetClientById(Guid id);

        Task Add(Teacher teacher);
        Task Modify(Teacher teacher);
        Task<Teacher> GetTeacherById(Guid id);

    }
}
