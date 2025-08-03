using FitnessTracker.Domain.Entities;
using FitnessTracker.Domain.Interfaces.Repositories;
using FitnessTracker.Services.Abstract;
using FitnessTracker.Services.Abstractions;

namespace FitnessTracker.Services
{
    internal class UserService : BaseService<User>, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
            : base(userRepository)
        {
            {
                _userRepository = userRepository;
            }
        }
    }
}
