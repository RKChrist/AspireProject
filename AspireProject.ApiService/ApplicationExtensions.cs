using Application;
using AspireProject.ApiService.APIEndpointExtender;
using InfrastructureLayer;

namespace AspireProject.ApiService
{
    public static class ApplicationExtensions
    {
        public static void AddCleanArchitectureServices(this IServiceCollection services)
        {
            services.AddApplicationServices();
            services.AddInfrastructureServices();
        }

        public static void AddApplicationEndpoints(this IEndpointRouteBuilder endpoints)
        {
            endpoints.AddHomeEndpoints();
        }
    }
}
