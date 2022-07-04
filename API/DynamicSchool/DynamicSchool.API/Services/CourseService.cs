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
            await _unitOfWork.CourseRepository.Add(course);
            _unitOfWork.Commit(); 
        }

        public async Task Add(Level level)
        {            
            await _unitOfWork.CourseRepository.Add(level);
            _unitOfWork.Commit();            
        }

        public async Task Add(Lesson lesson)
        {          
            await _unitOfWork.CourseRepository.Add(lesson);
            _unitOfWork.Commit();            
        }

        public async Task Add(Question question)
        {
            await _unitOfWork.CourseRepository.Add(question);
            _unitOfWork.Commit();
        }

        public async Task Edit(Question question)
        {
            using (_unitOfWork.BeginTransaction())
            {                
                await _unitOfWork.CourseRepository.Edit(question);
                _unitOfWork.Commit();
            }
        }

        public async Task Add(ResponseQuestion response)
        {
            using (_unitOfWork.BeginTransaction())
            {                
                await _unitOfWork.CourseRepository.Add(response);                
                _unitOfWork.Commit();
            }            
        }

        public async Task Edit(ResponseQuestion response)
        {
            using (_unitOfWork.BeginTransaction())
            {
                await _unitOfWork.CourseRepository.Edit(response);
                _unitOfWork.Commit();
            }
        }

        public async Task<IEnumerable<CourseDTO>> List(Guid id)
        {           
            var courses = await _unitOfWork.CourseRepository.List(id);
            _unitOfWork.Commit();

            return courses;            
        }

        public async Task<IEnumerable<LevelDTO>> ListLevel(Guid id)
        {  
            var levels = await _unitOfWork.CourseRepository.ListLevel(id);
            _unitOfWork.Commit();

            return levels;            
        }

        public async Task<IEnumerable<QuestionDTO>> ListQuestion(Guid lessonId)
        {
            var questions = await _unitOfWork.CourseRepository.ListQuestion(lessonId);
            _unitOfWork.Commit();

            return questions;
        }

        public async Task<IEnumerable<ResponseDTO>> ListResponse(Guid lessonId)
        {
            var responses = await _unitOfWork.CourseRepository.ListResponse(lessonId);
            _unitOfWork.Commit();

            return responses;
        }
    }
}
