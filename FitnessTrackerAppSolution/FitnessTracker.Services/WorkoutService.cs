using AutoMapper;
using FitnessTracker.Contracts.DTOs;
using FitnessTracker.Domain.Entities;
using FitnessTracker.Domain.Interfaces.Repositories;
using FitnessTracker.Services.Abstract;
using FitnessTracker.Services.Abstractions;

namespace FitnessTracker.Services
{
    internal class WorkoutService : BaseService<Workout, WorkoutDto>, IWorkoutService
    {
        private readonly IWorkoutRepository _workoutRepository;

        public WorkoutService
            (
                IWorkoutRepository workoutRepository,
                IMapper mapper,
                IWorkoutTypeService workoutTypeService
            ) 
            :base
                (
                    workoutRepository,
                    mapper
                )
        {
            _workoutRepository = workoutRepository;
        }

        public override async Task<WorkoutDto?> GetByIdAsync(int id)
        {
            var workout = await _workoutRepository.GetByIdAsync(id,
                w => w.User,
                w => w.Type);

            return workout == null ? null : _mapper.Map<WorkoutDto>(workout);
        }

        public override async Task<IEnumerable<WorkoutDto>> GetAllAsync()
        {
            var workouts = await _workoutRepository.GetAllAsync(
                w => w.User,
                w => w.Type);

            return _mapper.Map<IEnumerable<WorkoutDto>>(workouts);
        }

        public async Task<List<WeeklyWorkoutStatsDto>> GetWeeklyStatsAsync(int userId, int month, int year)
        {
            var data = _mapper.Map<List<WeeklyWorkoutStatsDto>>(await _workoutRepository.GetWeeklyStatsAsync(userId, month, year));
            return data;
        }

        public async Task<IEnumerable<WorkoutDto>> GetAllByUserIdAsync(int userId)
        {
            return _mapper.Map<IEnumerable<WorkoutDto>>(await _workoutRepository.GetAllByUserIdAsync(userId));
        }
    }
}
