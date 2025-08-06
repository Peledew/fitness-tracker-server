using FitnessTracker.Domain.Entities;

namespace FitnessTracker.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IBaseRepository<User> 
    {
        Task<User?> GetByUsernameAsync(string username);
    }
}
