using DynamicSchool.Domain.DTO.People;
using DynamicSchool.Domain.Entities.People;
using DynamicSchool.Domain.Inteface.Repository;
using DynamicSchool.Infra.Data.Data.Command.People;
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

        public async Task Add(Client client)
        {
            await new CommandClient(_context, _transaction).Add(client);
        }

        public async Task Modify(Client client)
        {
            await new CommandClient(_context, _transaction).Modify(client);
        }

        public async Task ChangeStatus(Guid id, bool status)
        {
            await new CommandClient(_context, _transaction).ChangeStatus(id, status);
        }

        public async Task Add(Teacher teacher)
        {
            await new CommandTeacher(_context, _transaction).Add(teacher);
        }     

        public Task Modify(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public Task<Teacher> GetTeacherById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Add(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
