using DynamicSchool.API.Interfaces;
using DynamicSchool.Domain.DTO.Course;
using DynamicSchool.Domain.Entities.Courses;
using DynamicSchool.Domain.Inteface.UoW;
using System;
using System.Collections.Generic;
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

        public async Task<IEnumerable<CourseDTO>> List(Guid id)
        {
            using (_unitOfWork.BeginTransaction())
            {
                var courses = await _unitOfWork.CourseRepository.List(id);
                _unitOfWork.Commit();

                return courses;
            }
        }

        public async Task<IEnumerable<LevelDTO>> ListLevel(Guid id)
        {
            using (_unitOfWork.BeginTransaction())
            {
                var levels = await _unitOfWork.CourseRepository.ListLevel(id);
                _unitOfWork.Commit();

                return levels;
            }
        }
    }
}
