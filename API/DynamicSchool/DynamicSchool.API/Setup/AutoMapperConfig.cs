using AutoMapper;
using DynamicSchool.API.Model.Request;
using DynamicSchool.Domain.Entities.Courses;
using DynamicSchool.Domain.Entities.People;

namespace DynamicSchool.API.Setup
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            
            CreateMap<TeacherRequest, Teacher>()
                .ConstructUsing(x => new Teacher(x.Name, x.Document, x.CellPhone, x.BirthDay, x.ClientOrigin));

            CreateMap<CourseRequest, Course>()
               .ConstructUsing(x => new Course(x.Name, x.TeacherId));


        }
    }
}
