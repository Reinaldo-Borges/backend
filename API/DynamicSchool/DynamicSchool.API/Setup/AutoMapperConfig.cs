using DynamicSchool.API.Model.Response;
using DynamicSchool.Domain.Entities.People;
using System;
using AutoMapper;


namespace DynamicSchool.API.Setup
{
    public class AutoMapperConfig : AutoMapper.Profile
    {
        public AutoMapperConfig()
        {
            
            CreateMap<ClientRequest, Client>().ReverseMap();
        }
    }
}
