using DynamicSchool.Domain.DTO.People;
using DynamicSchool.Domain.Entities.People;
using DynamicSchool.Domain.Intefaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicSchool.API.Interfaces
{
    public interface IPeopleService
    {
        Task<ClientDTO> GetClientById(Guid id);
        Task Add(IClient client);
    }
}
