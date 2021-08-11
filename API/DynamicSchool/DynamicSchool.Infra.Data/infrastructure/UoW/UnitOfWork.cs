using DynamicSchool.Domain.Inteface.Repository;
using DynamicSchool.Domain.Inteface.UoW;
using DynamicSchool.Infra.Data.infrastructure.Context;
using DynamicSchool.Infra.Data.infrastructure.Repository;
using System;

namespace DynamicSchool.Infra.Data.infrastructure.UoW
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationContext _context;
        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
        }

        private IPeopleRepository _peopleRepository;
        public IPeopleRepository PeopleRepository
        {
            get => _peopleRepository ?? (_peopleRepository = new PeopleRepository(_context));
        }

        private ICourseRepository _courseRepository;
        public ICourseRepository CourseRepository
        {
            get => _courseRepository ?? (_courseRepository = new CourseRepository(_context));
        }     

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.DisposeAsync();
        }

    
    }
}
