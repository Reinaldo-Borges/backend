using DynamicSchool.Domain.Entities.People;
using DynamicSchool.Domain.Inteface.Repository;
using DynamicSchool.Infra.Data.infrastructure.Context;
using System;
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

        public async Task Add(Client client)
        {
            await _context.Clients.AddAsync(client);
        }

        public async Task Modify(Client client)
        {
            _context.Clients.Update(client);
        }

        public async Task<Client> GetClientById(Guid id)
        {
            return await _context.Clients.FindAsync(id);
        }

        public async Task Add(Teacher teacher)
        {
            await _context.Teachers.AddAsync(teacher);
        }

        public async Task Modify(Teacher teacher)
        {
            _context.Teachers.Update(teacher);
        }

        public async Task<Teacher> GetTeacherById(Guid id)
        {
            return await _context.Teachers.FindAsync(id);
        }

        public async Task Add(Student student)
        {
            await _context.Students.AddAsync(student);
        }
    }
}
