using DynamicSchool.Domain.Entities.Courses;
using DynamicSchool.Domain.Inteface.Repository;
using DynamicSchool.Infra.Data.Data.Command.Courses;
using System.Data;
using System.Threading.Tasks;

namespace DynamicSchool.Infra.Data.infrastructure.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly IDbConnection _context;
        private IDbTransaction _transaction;

        public CourseRepository(IDbConnection context, IDbTransaction transaction)
        {
            _context = context;
            _transaction = transaction;
        }
       
        public async Task Add(Course course)
        {
            await new CourseCommand(_context, _transaction).Add(course);
        }
        
    }
}
