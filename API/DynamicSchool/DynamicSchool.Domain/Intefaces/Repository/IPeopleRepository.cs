using DynamicSchool.Core.Enum;
using DynamicSchool.Domain.DTO.People;
using DynamicSchool.Domain.Entities.People;
using System;
using System.Threading.Tasks;

namespace DynamicSchool.Domain.Inteface.Repository
{
    public interface IPeopleRepository
    {
        //Task<ClientDTO> GetClientById(Guid id);
        Task Add(Client client);
        Task Modify(Client client);
      //  Task ChangeStatus(Guid id, bool status);
        Task Add(Teacher teacher);

    }
}
