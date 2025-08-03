using FitnessTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Contracts.DTOs
{
    public class WorkoutDto
    {
        public int? Id { get; set; }

        public int? UserId { get; set; }

        public WorkoutType? Type { get; set; }

        public TimeSpan? Duration { get; set; }

        public int? BurnedCalories { get; set; }

        public int? DifficultyLevel { get; set; }

        public int? PostWorkoutFatigueLevel { get; set; }

        public string? AdditionalNotes { get; set; }
    }
}
