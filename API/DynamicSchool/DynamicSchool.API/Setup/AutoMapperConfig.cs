using AutoMapper;
using System;

namespace DynamicSchool.API.Setup
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Object, Object>().ReverseMap();
        }
    }
}
