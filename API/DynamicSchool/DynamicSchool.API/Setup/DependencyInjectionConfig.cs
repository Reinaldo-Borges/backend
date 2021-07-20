using DynamicSchool.API.Interfaces;
using DynamicSchool.API.Model;
using DynamicSchool.API.Services;
using DynamicSchool.Domain.Factories;
using DynamicSchool.Domain.Inteface.UoW;
using DynamicSchool.Infra.Data.infrastructure.Context;
using DynamicSchool.Infra.Data.infrastructure.UoW;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Data.SqlClient;

namespace DynamicSchool.API.Setup
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ApplicationContext>();
            services.AddScoped<JwtSettings>();

            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IClientFactory, ClientFactory>();          

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IDbConnection>(x => new SqlConnection(configuration.GetConnectionString("SqlConnection")));
            
            return services;
        }
    }
}
