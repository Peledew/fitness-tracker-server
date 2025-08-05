using AutoMapper;
using FitnessTracker.Contracts.DTOs;
using FitnessTracker.Domain.Entities;
using FitnessTracker.Domain.Interfaces.Repositories;
using FitnessTracker.Services.Abstract;
using FitnessTracker.Services.Abstractions;

namespace FitnessTracker.Services
{
    internal class UserService : BaseService<User, UserDto>, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService
            (
                IUserRepository userRepository,
                IMapper mapper
            )
            : base
                (
                    userRepository,
                    mapper
                )
        {
            {
                _userRepository = userRepository;
            }
        }
    }
}
