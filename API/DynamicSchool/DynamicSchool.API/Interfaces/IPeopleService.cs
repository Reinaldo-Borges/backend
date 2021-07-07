using DynamicSchool.Domain.DTO.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicSchool.API.Interfaces
{
    public interface IPeopleService
    {
        Task<ClientDTO> GetClientById(Guid id);
    }
}
