using FitnessTracker.Domain.Interfaces.Repositories;
using FitnessTracker.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FitnessTracker.Infrastructure.Extensions
{
    public static class InfrastructureServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IWorkoutTypeRepository, WorkoutTypeRepository>();

            return services;
        }
    }
}
