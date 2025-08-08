using FitnessTracker.Contracts.DTOs;
using FitnessTracker.Domain.Entities;

namespace FitnessTracker.Services.Abstractions
{
    public interface IWorkoutService : IBaseService<WorkoutDto> 
    {
        Task<List<WeeklyWorkoutStatsDto>> GetWeeklyStatsAsync(int userId, int month, int year);
        Task<IEnumerable<WorkoutDto>> GetAllByUserIdAsync(int userId);
    }
}
