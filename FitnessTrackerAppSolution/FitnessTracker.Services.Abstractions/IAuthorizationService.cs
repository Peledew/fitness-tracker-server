using FitnessTracker.Domain.Entities;
using FitnessTracker.Contracts.DTOs;

namespace FitnessTracker.Services.Abstractions
{
    public interface IAuthorizationService
    {
        string GenerateJwtToken(User user);
        TokenDto ManageTokens(User user);
    }
}
