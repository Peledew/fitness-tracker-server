using FitnessTracker.Domain.Entities;
using FitnessTracker.Domain.Interfaces.Repositories;
using FitnessTracker.Services.Abstract;
using FitnessTracker.Services.Abstractions;

namespace FitnessTracker.Services
{
    internal class WorkoutTypeService : BaseService<WorkoutType>, IWorkoutTypeService
    {
        private readonly IWorkoutTypeRepository _workoutTypeRepository;

        public WorkoutTypeService(IWorkoutTypeRepository workoutTypeRepository)
            : base(workoutTypeRepository)
        {
            _workoutTypeRepository = workoutTypeRepository;
        }
    }
}
