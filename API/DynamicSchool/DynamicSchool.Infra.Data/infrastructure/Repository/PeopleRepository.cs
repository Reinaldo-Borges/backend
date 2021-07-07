using DynamicSchool.Domain.DTO.People;
using DynamicSchool.Domain.Inteface.Repository;
using DynamicSchool.Infra.Data.Data.Query.People;
using System;
using System.Data;
using System.Threading.Tasks;

namespace DynamicSchool.Infra.Data.infrastructure.Repository
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly IDbConnection _context;
        private IDbTransaction _transaction;

        public PeopleRepository(IDbConnection context, IDbTransaction transaction)
        {
            _context = context;
            _transaction = transaction;            
        }

        public async Task<ClientDTO> GetClientById(Guid id)
        {
            return await new QueryClient(_context, _transaction).GetClientById(id);
        }
    }
}
