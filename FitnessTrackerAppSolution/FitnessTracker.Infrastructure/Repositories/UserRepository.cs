using FitnessTracker.Domain.Entities;
using FitnessTracker.Domain.Interfaces.Repositories;
using FitnessTracker.Infrastructure.Context;
using FitnessTracker.Infrastructure.Repositories.Abstract;

namespace FitnessTracker.Infrastructure.Repositories
{
    internal class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context) { }
    }
}
