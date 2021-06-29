using Microsoft.Extensions.DependencyInjection;

namespace DynamicSchool.API.Setup
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {

            //services.AddScoped<verdepois>();
            return services;
        }
    }
}
