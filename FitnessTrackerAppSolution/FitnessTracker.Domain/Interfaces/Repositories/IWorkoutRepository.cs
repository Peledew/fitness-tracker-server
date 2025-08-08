using FitnessTracker.Domain.Entities;
using FitnessTracker.Domain.Records;

namespace FitnessTracker.Domain.Interfaces.Repositories
{
    public interface IWorkoutRepository : IBaseRepository<Workout> 
    {
        Task<IEnumerable<WeeklyWorkoutStatsRecord>> GetWeeklyStatsAsync(int userId, int month, int year);
        Task<IEnumerable<Workout>> GetAllByUserIdAsync(int userId);
    }
}
