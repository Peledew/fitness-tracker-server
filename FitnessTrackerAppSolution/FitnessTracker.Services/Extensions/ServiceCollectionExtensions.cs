using FitnessTracker.Services.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace FitnessTracker.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IWorkoutTypeService, WorkoutTypeService>();

            return services;
        }
    }
}
