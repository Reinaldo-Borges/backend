using DynamicSchool.Domain.DTO.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSchool.Domain.Inteface.Repository
{
    public interface IPeopleRepository
    {
        Task<ClientDTO> GetClientById(Guid id);

    }
}
