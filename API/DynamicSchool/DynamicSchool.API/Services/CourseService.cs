using DynamicSchool.API.Interfaces;
using DynamicSchool.Domain.Entities.Courses;
using DynamicSchool.Domain.Inteface.UoW;
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

        public async Task Add(Level level)
        {
            using (_unitOfWork.BeginTransaction())
            {
                await _unitOfWork.CourseRepository.Add(level);

                _unitOfWork.Commit();
            }
        }

        public async Task Add(Lesson lesson)
        {
            using (_unitOfWork.BeginTransaction())
            {
                await _unitOfWork.CourseRepository.Add(lesson);

                _unitOfWork.Commit();
            }
        }
    }
}
