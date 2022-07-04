using DynamicSchool.Domain.Entities.Registrations;
using DynamicSchool.Domain.Inteface.Repository;
using DynamicSchool.Infra.Data.infrastructure.Context;
using System.Data;
using System.Threading.Tasks;

namespace DynamicSchool.Infra.Data.infrastructure.Repository
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private readonly IDbConnection _context;
        private IDbTransaction _transaction;

        public RegistrationRepository(IDbConnection context, IDbTransaction transaction)
        {
            _context = context;
            _transaction = transaction;
        }

        public Task Add(Registration registration)
        {
            throw new System.NotImplementedException();
        }

        public Task Add(CourseProgress courseProgress)
        {
            throw new System.NotImplementedException();
        }
    }
}
