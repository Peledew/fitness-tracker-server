using FitnessTracker.Domain.Entities;
using FitnessTracker.Domain.Interfaces.Repositories;
using FitnessTracker.Infrastructure.Context;
using FitnessTracker.Infrastructure.Repositories.Abstract;

namespace FitnessTracker.Infrastructure.Repositories
{
    internal class WorkoutTypeRepository : BaseRepository<WorkoutType>, IWorkoutTypeRepository
    {
        public WorkoutTypeRepository (AppDbContext context) : base (context) { }
    }
}
