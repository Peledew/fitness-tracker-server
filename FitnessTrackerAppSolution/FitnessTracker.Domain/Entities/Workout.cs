using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTracker.Domain.Entities
{
    [Table("workouts")]
    public class Workout
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [ForeignKey("UserId")]
        public required User User { get; set; }
        public int UserId { get; set; }

        [ForeignKey("WorkoutTypeId")]
        public WorkoutType? Type { get; set; }
        public int? WorkoutTypeId { get; set; }

        [Required]
        public required TimeSpan Duration { get; set; }

        public int? BurnedCalories { get; set; }

        [Required]
        public required int DifficultyLevel { get; set; }

        [Required]
        public required int PostWorkoutFatigueLevel { get; set; }

        public string? AdditionalNotes { get; set; }
    }
}
