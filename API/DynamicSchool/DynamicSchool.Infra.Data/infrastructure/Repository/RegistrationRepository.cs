using DynamicSchool.Domain.Entities.Registrations;
using DynamicSchool.Domain.Inteface.Repository;
using DynamicSchool.Infra.Data.infrastructure.Context;
using System.Threading.Tasks;

namespace DynamicSchool.Infra.Data.infrastructure.Repository
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private readonly ApplicationContext _context;

        public RegistrationRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Add(Registration registration)
        {
             _context.Registrations.Add(registration);
        }
    }
}
