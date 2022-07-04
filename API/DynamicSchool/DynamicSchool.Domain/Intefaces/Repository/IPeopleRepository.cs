using DynamicSchool.Domain.DTO.People;
using DynamicSchool.Domain.Entities.People;
using System;
using System.Threading.Tasks;

namespace DynamicSchool.Domain.Inteface.Repository
{
    public interface IPeopleRepository
    {
        Task Add(Client client);
        Task Modify(Client client);
        Task<ClientDTO> GetClientById(Guid id);

        Task Add(Teacher teacher);
        Task Modify(Teacher teacher);
        Task<Teacher> GetTeacherById(Guid id);

        Task Add(Student student);

    }
}
