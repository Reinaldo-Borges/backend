using DynamicSchool.API.Model.Request;
using DynamicSchool.Core.Enum;
using DynamicSchool.Domain.Entities.Courses;
using DynamicSchool.Domain.Entities.People;
using DynamicSchool.Domain.Entities.Registrations;
using System;

namespace DynamicSchool.API.Extensions
{
    public static class RequestToEntityExtensions
    {
        public static Course ToCourse(this CourseRequest courseRequest)
        {
            return new Course(courseRequest.Name, courseRequest.TeacherId)
                        .SetDescription(courseRequest.Description)
                        .SetId<Course>(courseRequest.Id);
        }

        public static Level ToLevel(this LevelRequest levelRequest)
        {
            return new Level(levelRequest.Name, levelRequest.CourseId)
                        .SetCode(levelRequest.Code)
                        .SetId<Level>(levelRequest.Id);
        }

        public static Lesson ToLesson(this LessonRequest lessonRequest)
        {
            return new Lesson(lessonRequest.Name, lessonRequest.LevelId)
                        .SetDescription(lessonRequest.Description)
                        .SetImage(lessonRequest.Image)
                        .SetId<Lesson>(lessonRequest.Id);
        }

        public static Teacher ToTeacher(this TeacherRequest teacherRequest)
        {
            return new Teacher(teacherRequest.Name, teacherRequest.Document, teacherRequest.CellPhone, teacherRequest.BirthDay, teacherRequest.ClientOrigin)
                        .SetEmail(teacherRequest.Email)
                        .SetResume(teacherRequest.Resume)
                        .SetId<Teacher>(teacherRequest.Id);
        }

        public static Student ToStudent(this StudentRequest studentRequest)
        {
            return new Student(studentRequest.Name, studentRequest.ClientId)
                        .SetEmail(studentRequest.Email)
                        .SetCellPhone(studentRequest.CellPhone)
                        .SetId<Student>(studentRequest.Id);
        }

        public static Question ToQuestion(this QuestionRequest questionRequest)
        {
            //Ver depois esse TypeQuestionEnum
            return new Question(questionRequest.Description, (TypeQuestionEnum)questionRequest.TypeQuestion, questionRequest.LessonId)                     
                        .SetId<Question>(questionRequest.Id);
        }

        public static ResponseQuestion ToResponse(this ResponseRequest responseRequest)
        {

            return new ResponseQuestion(responseRequest.Description, responseRequest.IsTrue, responseRequest.QuestionId)
                        .SetReason(responseRequest.Reason)
                        .SetOrder(responseRequest.Order)
                        .SetId<ResponseQuestion>(responseRequest.Id);
        }

        public static Registration ToRegistration(this RegistrationRequest registrationRequest)
        {
            return new Registration(registrationRequest.StudentId, registrationRequest.CourseId);                        
        }

        public static CourseProgress ToCourseProgress(this CourseProgressRequest courseProgressRequest)
        {
            return new CourseProgress(courseProgressRequest.RegistrationId, courseProgressRequest.LessonId);
        }

    }
}
