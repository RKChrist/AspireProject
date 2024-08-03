using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(x => {
                        x.RegisterServicesFromAssembly(typeof(DependencyExtensions).Assembly);
            });
        }
    }
}
