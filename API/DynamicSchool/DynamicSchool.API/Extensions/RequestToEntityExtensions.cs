using DynamicSchool.API.Model.Request;
using DynamicSchool.Domain.Entities.Courses;
using DynamicSchool.Domain.Entities.People;
using DynamicSchool.Domain.Entities.Registrations;

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

        public static Registration ToRegistration(this RegistrationRequest registrationRequest)
        {
            return new Registration(registrationRequest.StudentId, registrationRequest.CourseId);
        }
    }
}
