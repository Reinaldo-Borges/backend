using DynamicSchool.Domain.DTO.People;
using DynamicSchool.Domain.Intefaces.Entities;
using System;
using System.Threading.Tasks;

namespace DynamicSchool.API.Interfaces
{
    public interface IPeopleService
    {
        Task<ClientDTO> GetClientById(Guid id);
        Task Add(IClient client);
        Task Modify(IClient client);
        Task ChangeStatus(Guid id, bool status);
    }
}
