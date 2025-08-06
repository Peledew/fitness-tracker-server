namespace FitnessTracker.Domain.Records
{
    public class WeeklyWorkoutStatsRecord
    {
        public int WeekNumber { get; set; }
        public int WorkoutCount { get; set; }
        public double AverageDifficultyLevel { get; set; }
        public double AveragePostWorkoutFatigueLevel { get; set; }
        public int TotalDurationMinutes { get; set; }
    }
}
