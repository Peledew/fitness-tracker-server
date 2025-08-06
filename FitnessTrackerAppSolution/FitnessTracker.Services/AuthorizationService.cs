using FitnessTracker.Contracts.DTOs;
using FitnessTracker.Domain.Entities;
using FitnessTracker.Services.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FitnessTracker.Services
{
    internal class AuthorizationService : IAuthorizationService
    {
        private readonly IUserService _userService;
        private readonly string _jwtKey;

        public AuthorizationService(IUserService userService, IConfiguration configuration)
        {
            _userService = userService;
            _jwtKey = configuration["Jwt:Key"]!;
        }

        public string GenerateJwtToken(User user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtKey));
            var identity = new ClaimsIdentity(
            [
                new Claim(ClaimTypes.Role, user.Role.ToString()),
                new Claim(ClaimTypes.Name,$"{user.Username}"),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            ]);

            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = identity,
                Expires = DateTime.Now.AddDays(5),
                SigningCredentials = credentials
            };
            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            return jwtTokenHandler.WriteToken(token);
        }

        //Prepare for Refresh token future implementation
        public TokenDto ManageTokens(User user)
        {
            var token = GenerateJwtToken(user);
            var newAccessToken = token;

            return new TokenDto(newAccessToken);
        }
    }
}
