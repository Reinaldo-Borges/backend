using DynamicSchool.API.Interfaces;
using DynamicSchool.Domain.Entities.Courses;
using DynamicSchool.Domain.Inteface.UoW;
using System;
using System.Threading.Tasks;

namespace DynamicSchool.API.Services
{
    public class CourseService : ICourseService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CourseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Add(Course course)
        {
            using (_unitOfWork.BeginTransaction())
            {
                await _unitOfWork.CourseRepository.Add(course);

                _unitOfWork.Commit();                
            }
        }
    }
}
