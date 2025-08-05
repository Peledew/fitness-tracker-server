using FitnessTracker.Domain.Entities;
using FitnessTracker.Domain.Interfaces.Repositories;
using FitnessTracker.Infrastructure.Context;
using FitnessTracker.Infrastructure.Repositories.Abstract;

namespace FitnessTracker.Infrastructure.Repositories
{
    internal class WorkoutRepository : BaseRepository<Workout>, IWorkoutRepository
    {
        public WorkoutRepository(AppDbContext context) : base(context) { }
    }
}
