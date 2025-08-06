namespace FitnessTracker.Contracts.DTOs
{
    public class WeeklyWorkoutStatsDto
    {
        public int? WeekNumber { get; set; }
        public TimeSpan? TotalDuration { get; set; }
        public int? WorkoutCount { get; set; }
        public double? AverageDifficultyLevel { get; set; }
        public double? AveragePostWorkoutFatigueLevel { get; set; }
    }
}
