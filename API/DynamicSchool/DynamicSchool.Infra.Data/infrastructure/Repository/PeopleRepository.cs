using DynamicSchool.Domain.Entities.People;
using DynamicSchool.Domain.Inteface.Repository;
using DynamicSchool.Infra.Data.infrastructure.Context;
using System.Threading.Tasks;

namespace DynamicSchool.Infra.Data.infrastructure.Repository
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly ApplicationContext _context;

        public PeopleRepository(ApplicationContext context)
        {
            _context = context;
        }

        //public async Task<Client> GetClientById(Guid id)
        //{

        //    return await _context.Clients.Where(c => c.Id == id);
        //}

        public async Task Add(Client client)
        {
            _context.Set<Client>().Add(client);//  new CommandClient(_context, _transaction).Add(client);
        }

        public async Task Modify(Client client)
        {
            _context.Set<Client>().Update(client); // await new CommandClient(_context, _transaction).Modify(client);
        }

        //public async Task ChangeStatus(Guid id, bool status)
        //{
        //    await new CommandClient(_context, _transaction).ChangeStatus(id, status);
        //}

        public async Task Add(Teacher teacher)
        {
             _context.Teachers.Add(teacher); //await new CommandTeacher(_context, _transaction).Add(teacher);
        }

     
    }
}
