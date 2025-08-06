using FitnessTracker.Contracts.DTOs;

namespace FitnessTracker.Services.Abstractions
{
    public interface IWorkoutService : IBaseService<WorkoutDto> 
    {
        Task<List<WeeklyWorkoutStatsDto>> GetWeeklyStatsAsync(int userId, int month, int year);
    }
}
