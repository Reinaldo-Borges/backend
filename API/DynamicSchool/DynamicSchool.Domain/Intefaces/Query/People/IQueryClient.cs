using DynamicSchool.Domain.DTO.People;
using System;
using System.Threading.Tasks;

namespace DynamicSchool.Domain.Intefaces.Query.People
{
    public interface IQueryClient
    {
        Task<ClientDTO> GetClientById(Guid id);
    }
}
