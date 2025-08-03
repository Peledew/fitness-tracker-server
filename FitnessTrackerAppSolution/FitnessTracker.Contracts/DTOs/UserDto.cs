using FitnessTracker.Domain.Entities;
using FitnessTracker.Shared.Enums;

namespace FitnessTracker.Contracts.DTOs
{
    public class UserDto
    {
        public int? Id { get; set; }

        public string? FirstName { get; set; }

        public  string? LastName { get; set; }

        public  string? Username { get; set; }

        public  string? Password { get; set; }

        public  string? Email { get; set; }

        public UserGender? Gender { get; set; }

        public UserRole? Role { get; set; }

        public ICollection<Workout>? Workouts { get; set; }
    }
}
