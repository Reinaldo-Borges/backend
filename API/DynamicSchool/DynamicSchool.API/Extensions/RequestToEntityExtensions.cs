using DynamicSchool.API.Model.Request;
using DynamicSchool.Domain.Entities.Courses;
using DynamicSchool.Domain.Entities.People;

namespace DynamicSchool.API.Extensions
{
    public static class RequestToEntityExtensions
    {
        public static Course ToCourse(this CourseRequest courseRequest)
        {
            return new Course(courseRequest.Name, courseRequest.TeacherId)
                        .SetDescription(courseRequest.Description);
                
        }

        public static Level ToLevel(this LevelRequest levelRequest)
        {
            return new Level(levelRequest.Name, levelRequest.CourseId)
                        .SetCode(levelRequest.Code);
        }

        public static Lesson ToLesson(this LessonRequest lessonRequest)
        {
            return new Lesson(lessonRequest.Name, lessonRequest.LevelId)
                        .SetDescription(lessonRequest.Description)
                        .SetImage(lessonRequest.Image);
        }






        public static Teacher ToTeacher(this TeacherRequest teacherRequest)
        {
            return new Teacher(teacherRequest.Name, teacherRequest.Document, teacherRequest.CellPhone, teacherRequest.BirthDay, teacherRequest.ClientOrigin)
                        .SetEmail(teacherRequest.Email)
                        .SetResume(teacherRequest.Resume);
        }



    }
}
