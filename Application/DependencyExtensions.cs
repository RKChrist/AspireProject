using ApplicationLayer;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using FluentValidation;

namespace Application
{
    public static class DependencyExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddCQRSHandlers()
                    .AddAutoMapper();
        }

        public static IServiceCollection AddCQRSHandlers(this IServiceCollection services)
        {
            var assembly = typeof(DependencyExtensions).Assembly;
            services.AddMediatR(x => {
                x.RegisterServicesFromAssembly(assembly);
            });
            ValidatorOptions.Global.DefaultClassLevelCascadeMode = CascadeMode.Stop;
            ValidatorOptions.Global.DefaultRuleLevelCascadeMode = CascadeMode.Stop;
            services.AddValidatorsFromAssembly(assembly);
            return services;
        }

        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MapperProfile));

            return services;
        }
    }
}
