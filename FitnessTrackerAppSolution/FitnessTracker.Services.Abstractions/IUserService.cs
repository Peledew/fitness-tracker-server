using FitnessTracker.Contracts.DTOs;
using FitnessTracker.Domain.Entities;

namespace FitnessTracker.Services.Abstractions
{
    public interface IUserService : IBaseService<UserDto> 
    {
        Task<User?> AuthenticateUserAsync(LogInDto user);
        bool ValidatePassword(string enteredPassword, User user);
    }
}
