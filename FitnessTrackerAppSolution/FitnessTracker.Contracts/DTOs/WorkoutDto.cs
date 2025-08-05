namespace FitnessTracker.Contracts.DTOs
{
    public class WorkoutDto
    {
        public int? Id { get; set; }

        public UserDto? User { get; set; }
        public int? UserId { get; set; }

        public WorkoutTypeDto? Type { get; set; }
        public int? WorkoutTypeId { get; set; }

        public TimeSpan? Duration { get; set; }

        public int? BurnedCalories { get; set; }

        public int? DifficultyLevel { get; set; }

        public int? PostWorkoutFatigueLevel { get; set; }

        public string? AdditionalNotes { get; set; }
    }
}
